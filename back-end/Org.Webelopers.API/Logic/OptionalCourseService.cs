using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;

using Org.Webelopers.Api.Models.Persistence.OptionalCourses;



namespace Org.Webelopers.Api.Logic
{
    public class OptionalCourseService : IOptionalCourseService
    {
        private readonly DatabaseContext _context;
        private readonly OptionalCourseAssigner _optionalCourseAssigner;

        public OptionalCourseService(DatabaseContext context)
        {
            _context = context;
            _optionalCourseAssigner = new OptionalCourseAssigner(_context);
        }

        #region PrivateFindMethods
        
        private OptionalCourse FindOptionalCourseAndThrowIfNullReference(Predicate<OptionalCourse> predicate, String exceptionMessage) => 
            Utils.ThrowIfNullReference(_context.FindEntity(predicate), exceptionMessage);

        private OptionalCourse FindOptionalCourseByIdAndThrowIfNullReference(Guid courseId) => FindOptionalCourseAndThrowIfNullReference(
            course => course.Id == courseId, 
            $"OptionalCourse with id: {courseId} was not found\n");

        #endregion

        public List<OptionalCourse> FilterCourses(Predicate<OptionalCourse> filterPredicate) =>
            _context.OptionalCourses.Where(course => filterPredicate(course)).ToList();

        #region PrivateSetCoursePreferenceMethods
        
        private void UpdateCoursePreferenceValue(Guid studentContractSemesterId, Guid courseId, short preferenceValue,
            OptionalCoursePreference optionalCoursePreference)
        {
            if (optionalCoursePreference == null) // create OptionalCoursePreference if doesn't exist
            {
                _context.Add(new OptionalCoursePreference()
                {
                    Id = Guid.NewGuid(),
                    Preference = preferenceValue,
                    StudentContractSemesterId = studentContractSemesterId,
                    OptionalCourseId = courseId
                });
            }
            else // update OptionalCoursePreference if exists
            {
                optionalCoursePreference.Preference = preferenceValue;
            }
        }

        private OptionalCoursePreference GetCourseInContractAndThrowIfNullReference(Guid studentContractSemesterId,
            Guid courseId)
        {
            CheckIfCourseInContractAndThrowIfNullReference(studentContractSemesterId, courseId);

            return _context.FindEntity<OptionalCoursePreference>(
                coursePreference => coursePreference.StudentContractSemesterId == studentContractSemesterId &&
                                    coursePreference.OptionalCourseId == courseId
            );
        }

        private void CheckIfCourseInContractAndThrowIfNullReference(Guid studentContractSemesterId, Guid courseId)
        {
            var studentContractSemester = _context.FindEntityAndThrowIfNullReference<StudentContractSemester>(
                semester => semester.Id == studentContractSemesterId,
                $"StudentContractSemester with id: {studentContractSemesterId} was not found\n"
            );

            _context.FindEntityAndThrowIfNullReference<OptionalCourse>(
                course => course.Id == courseId && course.SemesterId == studentContractSemester.StudySemesterId,
                $"OptionalCourse with id: {courseId}, in semester with id: {studentContractSemesterId} was not found\n"
            );
        }

        #endregion

        public void SetCoursePreference(Guid studentContractSemesterId, Guid courseId, short preferenceValue)
        {
            Utils.ThrowIf<InvalidEnumArgumentException>(preferenceValue < 0, $"Expected preference value >= 0. Got {preferenceValue}");
            OptionalCoursePreference optionalCoursePreference = GetCourseInContractAndThrowIfNullReference(studentContractSemesterId, courseId);

            UpdateCoursePreferenceValue(studentContractSemesterId, courseId, preferenceValue, optionalCoursePreference);

            _context.SaveChanges();
        }

        public void ProposeCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);
            
            optionalCourse.IsProposed = true;
            
            _context.SaveChanges();
        }

        public void ApproveCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.IsApproved = true;
            
            _context.SaveChanges();
        }

        public void SetCourseCapacity(Guid courseId, int capacity)
        {
            Utils.ThrowIf<InvalidEnumArgumentException>(capacity <= 0, $"Expected capacity > 0. Got {capacity}");
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.MaxNumberOfStudent = capacity;

            _context.SaveChanges();
        }


        /// <summary>
        /// Get the number of preferences of an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of the optional course</param>
        /// <returns>The number of preferences for the given optional course. -1, if there's no optional course with the given id.</returns>
        private int GetNumberOfFollowers(Guid optionalCourseId) =>
            _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null
                ? -1
                : _context.OptionalCoursePreferences.Count(preference => preference.OptionalCourseId == optionalCourseId);

        /// <summary>
        /// Gets the number of students enrolled in an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of the optional course</param>
        /// <returns>The number of students enrolled in the given optional course. -1, if there's no optional course with the given id</returns>
        //private int GetNumberOfEnrollments(Guid optionalCourseId) =>
        //    _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null
        //        ? -1
        //    : 0;
        //Todo: Update to fit database rebuilt version
        //: _context.Contracts.Count(contract => contract.OptionalCourse.Id == optionalCourseId);

        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment()
        {
            // 1. get all approved optional courses with at least 20 followers
            var selectedOptionalCourses = _context.OptionalCourses.Where(course => course.IsApproved && GetNumberOfFollowers(course.Id) >= 20);
            int numberOfStudentsWithRandomOptionalCourseAssigned = 0;
            int numberOfStudentsWithNoOptionalCourseAssigned = 0;

            // 2. for each student, assign the the optional course with the highest priority that is selected

            // Todo: Update to fit database rebuilt version
            //foreach (StudyContract studyContract in _context.StudyContracts)
            //{
            //    var selectedPreferenceOptionalCourseId = _context.OptionalCoursePreferences
            //        .Where(preference => preference.StudyContract == studyContract)
            //        .OrderBy(preference => preference.Preference)
            //        .Select(preference => preference.OptionalCourseId) // the OptionalCourseIds of the preference of studyContract, sorted by preference value
            //        .FirstOrDefault(courseId =>
            //            courseId == selectedOptionalCourses
            //                .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
            //                .Select(course => course.Id)
            //                .FirstOrDefault(id => id == courseId));

            //    if (selectedPreferenceOptionalCourseId == Guid.Empty)
            //    {
            //        selectedPreferenceOptionalCourseId = selectedOptionalCourses
            //            .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
            //            .Select(course => course.Id).FirstOrDefault();
            //    }

            //    if (selectedPreferenceOptionalCourseId == Guid.Empty)
            //        numberOfStudentsWithNoOptionalCourseAssigned++;
            //    else
            //    {
            //        numberOfStudentsWithRandomOptionalCourseAssigned++;
            //        studyContract.OptionalCourseId = selectedPreferenceOptionalCourseId;
            //    }
            //}
            //_context.SaveChanges();
            return new OptionalCoursesAssignmentResults(){
               selectedOptionalCourses= selectedOptionalCourses.ToList(),
                numberOfStudentsWithRandomOptionalCourseAssigned = numberOfStudentsWithRandomOptionalCourseAssigned,
                numberOfStudentsWithNoOptionalCourseAssigned = numberOfStudentsWithNoOptionalCourseAssigned
            };
        }

        public List<OptionalCourseDto> GetOptionalCoursesByContractId(Guid contractId)
        {
            var yearId = _context.Contracts.FirstOrDefault(contract => contract.Id == contractId).StudyYearId;

            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).ToList();


            List<OptionalCourse> result = new List<OptionalCourse>();

            semesters.ForEach(semester => result.AddRange(_context.OptionalCourses.Where(course => course.SemesterId == semester.Id).ToList()));
            /*return _context.OptionalCourses.Where(course => course.SemesterId == semesters[0].Id).Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                TeacherId = course.TeacherId,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent

            }).ToList();*/
            return result.Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent

            }).ToList();

        }
        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference) => 
            _optionalCourseAssigner.AssignCoursesToStudents(assignToContractsWithNoPreference);

        public void SetCoursesPreferences(Guid studentContractSemesterId, List<Guid> coursesIds)
        {
            Func<Guid, Predicate<OptionalCoursePreference>> getPredicate = courseId =>
                preference =>
                    preference.StudentContractSemesterId == studentContractSemesterId &&
                    preference.OptionalCourseId == courseId;
                
            for (int i = 0; i < coursesIds.Count; i++)
            {
                // Predicate<OptionalCoursePreference> predicate = preference => 
                //     preference.StudentContractSemesterId == studentContractSemesterId && 
                //     preference.OptionalCourseId == coursesIds[i];
                
                // var preference =  _context.OptionalCoursePreferences.FirstOrDefault(preference => predicate(preference));

                var preference = _context.OptionalCoursePreferences.FirstOrDefault(preference => getPredicate(coursesIds[i])(preference));
                
                if (preference != null)
                {
                    preference.Preference = (short) i;
                }
            }
        }

        public List<OptionalCourseDto> GetOptionalCoursesBySemesterContractId(Guid semesterContractId)
        {

            var semesterId = _context.SemesterContracts.FirstOrDefault(contract => contract.Id == semesterContractId).StudySemesterId;
          
            return _context.OptionalCourses.Where(course => course.SemesterId == semesterId).Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent
            }).ToList();

       
        }
    }
}

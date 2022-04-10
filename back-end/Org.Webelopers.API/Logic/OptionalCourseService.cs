using System;
using System.Collections.Generic;
using System.Linq;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.OptionalCoursesService;

namespace Org.Webelopers.Api.Logic
{
    public class OptionalCourseService : IOptionalCourseService
    {
        private readonly DatabaseContext _context;

        public OptionalCourseService(DatabaseContext context)
        {
            _context = context;
        }

        public List<OptionalCourse> GetOptionalCourses() => _context.OptionalCourses.ToList();

        /// <summary>
        /// Sets or updates a preference for an optional course (only if the parameters conditions are met).
        /// </summary>
        /// <param name="preference">A non-negative number. The lower the value, the higher the preference. </param>
        /// <param name="contractId">the id of an existing contract</param>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <returns>
        /// True, if the preference was set. False, if the preference is below 0 or the contract doesn't exist or the optional course
        /// doesn't exist.
        /// </returns>
        public bool SetStudentOptionalCoursesPreference(short preference, Guid contractId, Guid optionalCourseId)
        {
            // parameters conditions checking
            if (preference < 0) { return false; }
            
            var contract = _context.StudyContracts.FirstOrDefault(contract => contract.Id == contractId);
            if (contract == null) return false; // if no contract was found

            if (_context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null) { return false; } // if no optional course was found
            
            // add/update the preference
            var optionalCoursePreference = _context.OptionalCoursePreferences.FirstOrDefault(coursePreference => coursePreference.StudyContractId == contractId &&
                coursePreference.OptionalCourseId == optionalCourseId);
            if (optionalCoursePreference == null)
            {
                optionalCoursePreference = new OptionalCoursePreference()
                {
                    Id = Guid.NewGuid(),
                    Preference = preference,
                    StudyContractId = contractId,
                    OptionalCourseId = optionalCourseId
                };
                _context.OptionalCoursePreferences.Add(optionalCoursePreference);
            }
            else
            {
                optionalCoursePreference.Preference = preference;
            }
            _context.SaveChanges();
            
            return true;
        }
        
        /// <summary>
        /// Gets the optional courses proposed by a teacher.
        /// </summary>
        /// <param name="teacherId">the id of the teacher of the courses</param>
        /// <returns>
        /// A list that contains the optional courses that were proposed by a given teacher.
        /// Empty, if teacherId doesn't belong to any existing teacher.
        /// </returns>
        public List<OptionalCourse> GetProposedOptionalCourses(Guid teacherId) => _context.OptionalCourses.Where(course => course.TeacherId == teacherId && course.IsProposed).ToList();

        /// <summary>
        /// Adds a new optional course.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="credits">Non-zero natural number</param>
        /// <param name="semesterId">the id of an existing semester</param>
        /// <param name="teacherId">the id of an existing teacher</param>
        /// <returns>True, if the optional was added. False, if the parameters conditions weren't met or the teacher already has
        /// a course with the given name.</returns>
        public bool AddOptionalCourse(string name, short credits, Guid semesterId, Guid teacherId)
        {
            // parameters conditions checking
            if (credits < 1) { return false; }
            if (_context.StudySemesters.FirstOrDefault(semester => semester.Id == semesterId) == null) { return false; }
            if (_context.Teachers.FirstOrDefault(teacher => teacher.Id == teacherId) == null) { return false; }
            if (_context.OptionalCourses.FirstOrDefault(course => course.TeacherId == teacherId && 
                                                            course.Name == name) == null) { return false; }

            _context.OptionalCourses.Add(new OptionalCourse()
            {
                Credits = credits,
                Id = Guid.NewGuid(),
                IsApproved = false,
                
            });
            _context.SaveChanges();
            
            return true;
        }

        /// <summary>
        /// Propose an optional course
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <param name="teacherId">the id of an existing teacher</param>
        /// <returns>True, if the optional course was proposed. False, if the optional course doesn't exist or the teacher already
        /// proposed the given optional course or they already proposed 2 optional courses.</returns>
        public bool ProposeOptionalCourse(Guid optionalCourseId, Guid teacherId)
        {
            var optionalCourse = _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId);
            if (optionalCourse == null) return false;

            var proposedOptionalCourses = GetProposedOptionalCourses(teacherId);
            if (proposedOptionalCourses.Count == 2 || proposedOptionalCourses.Exists(course => course.Id == optionalCourseId))
            {
                return false;
            }

            optionalCourse.IsProposed = true;
            _context.SaveChanges();
            
            return true;
        }

        /// <summary>
        /// Approve an optional course 
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course to be approved</param>
        /// <returns>True, if the optional course was approved or is already approved.
        /// False, if no optional course with the given id exists.</returns>
        public bool SetOptionalCourseApproval(Guid optionalCourseId)
        {
            var optionalCourse = _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId);
            if (optionalCourse == null) return false;

            optionalCourse.IsApproved = true;
            _context.SaveChanges();
            
            return true;
        }

        /// <summary>
        /// Sets the maximum number of students for an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <param name="maxNumberOfStudents">Non-negative value. The maximum number of students for the optional course given by the id</param>
        /// <returns>True, if the maximum number of students for the optional course was set. False, if the given maximum number is negative
        /// or the optional course doesn't exist</returns>
        public bool SetOptionalCourseMaxStudent(Guid optionalCourseId, int maxNumberOfStudents)
        {
            if (maxNumberOfStudents < 0) return false;
            var optionalCourse = _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId);
            if (optionalCourse == null) return false;

            optionalCourse.MaxNumberOfStudent = maxNumberOfStudents;
            _context.SaveChanges();
            
            return true;
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
        private int GetNumberOfEnrollments(Guid optionalCourseId) =>
            _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null 
                ? -1 
                : _context.StudyContracts.Count(contract => contract.OptionalCourse.Id == optionalCourseId);

        /// <summary>
        /// Assigns to students their first approved optional course preference which has at least 20 followers. If 2 or more optional courses have
        /// the same preference, then, the order in which they are chosen is undeterministic, making it the student's responsibility to
        /// decide upon the preference order.
        /// If no student's preference matched an approved optional course with at least 20 followers and with available seats, the student
        /// will be assigned to a random one that is available.
        /// </summary>
        /// <returns>The list of approved optional courses that have at least 20 followers.</returns>
        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment()
        {
            // 1. get all approved optional courses with at least 20 followers
            var selectedOptionalCourses = _context.OptionalCourses.Where(course => course.IsApproved && GetNumberOfFollowers(course.Id) >= 20);
            int numberOfStudentsWithRandomOptionalCourseAssigned = 0;
            int numberOfStudentsWithNoOptionalCourseAssigned = 0;
            
            // 2. for each student, assign the the optional course with the highest priority that is selected
            foreach (StudyContract studyContract in _context.StudyContracts)
            {
                var selectedPreferenceOptionalCourseId = _context.OptionalCoursePreferences
                    .Where(preference => preference.StudyContract == studyContract)
                    .OrderBy(preference => preference.Preference)
                    .Select(preference => preference.OptionalCourseId) // the OptionalCourseIds of the preference of studyContract, sorted by preference value
                    .FirstOrDefault(courseId => 
                        courseId  == selectedOptionalCourses
                            .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
                            .Select(course => course.Id)
                            .FirstOrDefault(id => id == courseId));

                if (selectedPreferenceOptionalCourseId == Guid.Empty)
                {
                    selectedPreferenceOptionalCourseId = selectedOptionalCourses
                        .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
                        .Select(course => course.Id).FirstOrDefault();
                }

                if (selectedPreferenceOptionalCourseId == Guid.Empty) 
                    numberOfStudentsWithNoOptionalCourseAssigned++;
                else
                {
                    numberOfStudentsWithRandomOptionalCourseAssigned++;
                    studyContract.OptionalCourseId = selectedPreferenceOptionalCourseId;
                }
            }
            _context.SaveChanges();
            return new OptionalCoursesAssignmentResults(selectedOptionalCourses.ToList(), numberOfStudentsWithRandomOptionalCourseAssigned, numberOfStudentsWithNoOptionalCourseAssigned);
        }
    }
}
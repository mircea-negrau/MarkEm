using System;
using System.Collections.Generic;
using System.Linq;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;
using Org.Webelopers.Api.Models.Persistence.OptionalCoursesService;

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

        public bool SetStudentOptionalCoursesPreference(short preference, Guid contractId, Guid optionalCourseId)
        {
            // parameters conditions checking
            if (preference < 0) { return false; }

            var contract = _context.Contracts.FirstOrDefault(contract => contract.Id == contractId);
            if (contract == null) return false; // if no contract was found

            if (_context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null) { return false; } // if no optional course was found

            // add/update the preference

            // TODO: Update to fit database rebuilt version
            //var optionalCoursePreference = _context.OptionalCoursePreferences.FirstOrDefault(coursePreference => coursePreference.StudyContractId == contractId &&
            //    coursePreference.OptionalCourseId == optionalCourseId);
            //if (optionalCoursePreference == null)
            //{
            //    optionalCoursePreference = new OptionalCoursePreference()
            //    {
            //        Id = Guid.NewGuid(),
            //        Preference = preference,
            //StudyContractId = contractId, 
            //        OptionalCourseId = optionalCourseId
            //    };
            //    _context.OptionalCoursePreferences.Add(optionalCoursePreference);
            //}
            //else
            //{
            //    optionalCoursePreference.Preference = preference;
            //}
            //_context.SaveChanges();

            return true;
        }

        public List<OptionalCourse> GetProposedOptionalCourses(Guid teacherId) => _context.OptionalCourses.Where(course => course.TeacherId == teacherId && course.IsProposed).ToList();

        public bool AddOptionalCourse(string name, short credits, Guid semesterId, Guid teacherId)
        {
            // parameters conditions checking

            // TODO: Update to fit database rebuilt version
            //if (credits < 1) { return false; }
            //if (_context.StudySemesters.FirstOrDefault(semester => semester.Id == semesterId) == null) { return false; }
            //if (_context.Teachers.FirstOrDefault(teacher => teacher.Id == teacherId) == null) { return false; }
            //if (_context.OptionalCourses.FirstOrDefault(course => course.TeacherId == teacherId &&
            //                                                course.Name == name) == null) { return false; }

            //_context.OptionalCourses.Add(new OptionalCourse()
            //{
            //    Credits = credits,
            //    Id = Guid.NewGuid(),
            //    IsApproved = false,

            //});
            //_context.SaveChanges();

            return true;
        }

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

        public bool SetOptionalCourseApproval(Guid optionalCourseId)
        {
            var optionalCourse = _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId);
            if (optionalCourse == null) return false;

            optionalCourse.IsApproved = true;
            _context.SaveChanges();

            return true;
        }

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
            return new OptionalCoursesAssignmentResults(selectedOptionalCourses.ToList(), numberOfStudentsWithRandomOptionalCourseAssigned, numberOfStudentsWithNoOptionalCourseAssigned);
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
    }
}
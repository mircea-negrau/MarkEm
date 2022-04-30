using System;
using System.Linq;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Logic
{
    public class OptionalCourseAssigner
    {
        private readonly DatabaseContext _context;

        public OptionalCourseAssigner(DatabaseContext context)
        {
            _context = context;
        }

        #region PrivateMethods
        
        /// <summary>
        /// Get the number of preferences of an optional course.
        /// </summary>
        /// <param name="courseId">the id of the optional course</param>
        /// <returns>
        /// The number of preferences for the given optional course.
        /// -1, if there's no optional course with the given id.
        /// </returns>
        private int GetNumberOfPreferences(Guid courseId) =>
            _context.OptionalCourses.FirstOrDefault(course => course.Id == courseId) == null
                ? -1
                : _context.OptionalCoursePreferences.Count(preference => preference.OptionalCourseId == courseId);

        private IQueryable<OptionalCourse> GetApprovedCoursesWithMinimumNumberOfFollowers(int minimumNumberOfFollowers) => _context.OptionalCourses.Where(course => course.IsApproved && GetNumberOfPreferences(course.Id) >= minimumNumberOfFollowers);

        private IQueryable<Guid> GetCoursesIdsSortedByPreferenceValue(Guid semesterContractId) =>
            _context.OptionalCoursePreferences
                .Where(preference => preference.StudentContractSemesterId == semesterContractId)
                .OrderBy(preference => preference.Preference)
                .Select(preference => preference.OptionalCourseId);

        /// <summary>
        /// Gets the number of students enrolled in an optional course.
        /// </summary>
        /// <param name="courseId">the id of the optional course</param>
        /// <returns>The number of students enrolled in the given optional course. -1, if there's no optional course with the given id</returns>
        private int GetNumberOfEnrollments(Guid courseId) =>
            _context.OptionalCourses.FirstOrDefault(course => course.Id == courseId) == null
                ? -1
                : _context.SemesterContracts.Count(contract => contract.Id == courseId);

        private IQueryable<Guid> GetIdsOfEnrollableCourses(IQueryable<OptionalCourse> courses) => courses
            .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
            .Select(course => course.Id);
        
        #endregion

        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference)
        {
            int numberOfAssignments = 0;
            var approvedCoursesWithAtLeast20Followers = GetApprovedCoursesWithMinimumNumberOfFollowers(20);
            var idsOfEnrollableCourses = GetIdsOfEnrollableCourses(approvedCoursesWithAtLeast20Followers); // {none|first instance is default} => no enrollable course left

            if (!idsOfEnrollableCourses.Any()) // no more enrollable courses left => stop
            {
                return numberOfAssignments;
            }

            // 2. for each student, assign the the optional course with the highest priority that is selected
            foreach (var contract in _context.SemesterContracts)
            {
                var coursesIdsInContractSortedByPreferenceValue = GetCoursesIdsSortedByPreferenceValue(contract.Id); // {none|first instance is default} => no preference
                
                if (!assignToContractsWithNoPreference && !coursesIdsInContractSortedByPreferenceValue.Any())
                {
                    continue;
                }

                // find the first preferred enrollable course
                var idOfDeterminedCourse = coursesIdsInContractSortedByPreferenceValue // TODO: use join, if it preserves sorted order
                    .FirstOrDefault(idOfPreferredCourse =>
                        idsOfEnrollableCourses.First(enrollableCourseId => enrollableCourseId == idOfPreferredCourse) == idOfPreferredCourse);
                
                // find random enrollable course if no match for the preference was found
                if (idOfDeterminedCourse == default && assignToContractsWithNoPreference)
                {
                    idOfDeterminedCourse = idsOfEnrollableCourses.FirstOrDefault();
                }

                // assign the course to the student (contract)
                if (idOfDeterminedCourse != default)
                {
                    contract.OptionalCourseId = idOfDeterminedCourse;
                    numberOfAssignments++;
                }
            }

            _context.SaveChanges();
            return numberOfAssignments;
        }
    }
}
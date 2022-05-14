using System;
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.Persistence.Courses;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;

namespace Org.Webelopers.Api.Contracts
{
    public interface IOptionalCourseService
    {
        /// <summary>
        /// Filters optional courses by a given predicate
        /// </summary>
        /// <param name="filterPredicate">a predicate that decides whether or not an OptionalCourse should be contained in the filter result</param>
        /// <returns>the list of all optional courses that passed the filter predicate</returns>
        public List<OptionalCourse> FilterCourses(Predicate<OptionalCourse> filterPredicate);

        public void SetCoursePreference(Guid studentContractSemesterId, Guid courseId, short preferenceValue);

        public void ProposeCourse(Guid courseId);

        public void ApproveCourse(Guid courseId);

        public void SetCourseCapacity(Guid courseId, int capacity);

        /// <summary>
        /// Assigns to students their first approved optional course preference which has at least 20 followers. If 2 or more optional courses have
        /// the same preference, then, the order in which they are chosen is undeterministic, making it the student's responsibility to
        /// decide upon the preference order.
        /// </summary>

        /// <returns>The results of the assignment: The list of approved optional courses that have at least 20 followers, the number of
        /// random optional courses assigned and the number of students with no optional course assigned.</returns>
        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment();
        public List<OptionalCourseDto> GetOptionalCoursesByContractId(Guid contractId);
        public List<OptionalCourseDto> GetOptionalCoursesBySemesterContractId(Guid contractId);

        /// <returns>the number of semester contracts that got a course assigned</returns>
        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference);

        public void SetCoursesPreferences(Guid studentContractSemesterId, List<Guid> coursesIds);
        
        
        public Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId);

        public void AddSamplesForGetOptionalStudentsWithGrade();

        public Task<TeacherOptionalStudentsWithGradeResponse> GetStudentsWithGrade(Guid courseId);

        public bool Exists(Guid courseId);
    }
}
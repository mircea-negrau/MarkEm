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

        #region Student
        public void SetCoursePreference(Guid studentContractSemesterId, Guid courseId, short preferenceValue);
        public void SetCoursesPreferences(Guid studentContractSemesterId, List<Guid> coursesIds);

        public List<OptionalCourseDto> GetOptionalCoursesByContractId(Guid contractId);
        public List<OptionalCourseDto> GetOptionalCoursesBySemesterContractId(Guid contractId);
        #endregion
        
        #region Teacher
        public ProposedCoursesIds GetProposed(Guid teacherId);
        public void Propose(Guid course1Id, Guid course2Id);
        
        public TeacherCourseDetailDto GetEnrichedCourseById(Guid courseId);
        public Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId);
        public Task<TeacherOptionalStudentsWithGradeResponse> GetStudentsWithGrade(Guid courseId);
        public Task<TeacherOptionals> GetEnrichedCoursesForTeacherOptionalsPage(Guid teacherId);
        #endregion

        #region Chief
        public void ApproveCourse(Guid courseId);
        public void DisapproveCourse(Guid courseId);
        public void SetCourseCapacity(Guid courseId, int capacity);
        /// <returns>the number of semester contracts that got a course assigned</returns>
        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference);
        public void AddSamplesForAssignCoursesToStudents();

        public Task<OptionalsChiefView> GetOptionalsChiefView(Guid chiefId);
        #endregion
        
        public bool Exists(Guid courseId);
        public bool IsCourseTaughtBy(Guid courseId, Guid teacherId);
    }
}
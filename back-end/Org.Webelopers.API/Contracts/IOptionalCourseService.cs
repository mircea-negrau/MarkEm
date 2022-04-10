
using System;
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;
using Org.Webelopers.Api.Models.OptionalCoursesService;

namespace Org.Webelopers.Api.Contracts
{
    public interface IOptionalCourseService
    {
        /// Returns all the Optional Courses
        public List<OptionalCourse> GetOptionalCourses();
        public bool SetStudentOptionalCoursesPreference(short preference, Guid contractId, Guid optionalCourseId); // TODO: contractId vs. studentId
        public List<OptionalCourse> GetProposedOptionalCourses(Guid teacherId);
        public bool AddOptionalCourse(string name, short credits, Guid semesterId, Guid teacherId);
        public bool ProposeOptionalCourse(Guid optionalCourseId, Guid teacherId); // TODO: maybe remove the teacherId and do the checking in the TeacherController
        public bool SetOptionalCourseApproval(Guid optionalCourseId);
        public bool SetOptionalCourseMaxStudent(Guid optionalCourseId, int maxNumberOfStudents);
        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment();
    }
}

using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IOptionalCourseService
    {
        public List<Course> getOptionalCourses();
        public void SetStudentOptionalCoursesPrefference();
        public int GetNumberOfProposedOptionalCourses();
        public void AddOptionalCourse();
        public void SetOptionalCourseApproval();
        public void SetOptionalCourseMaxStudent();
        public void StartOptionalCoursesAssignment();
    }
}
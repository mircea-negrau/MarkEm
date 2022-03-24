
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts.Curriculum
{
    public interface ICurriculumService
    {
        public List<Course> GetCourseClasses();
        public List<Course> GetStudentEnrolledClasses(int studentId);
        public List<Course> GetYearCurriculum(int year);
    }
}
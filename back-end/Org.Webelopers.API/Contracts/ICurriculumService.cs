
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface ICurriculumService
    {
        public Tuple<List<Course>, List<OptionalCourse>> GetStudentEnrolledCourses(Guid studentId);
        public List<Course> GetSemesterCurriculum(Guid semesterId);
        public List<Course> GetYearCurriculum(Guid yearId);
    }
}
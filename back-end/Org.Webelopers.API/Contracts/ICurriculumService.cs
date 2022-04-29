using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;
using System;

namespace Org.Webelopers.Api.Contracts
{
    public interface ICurriculumService
    {
        public Tuple<List<MandatoryCourse>, List<OptionalCourse>> GetStudentEnrolledCourses(Guid studentId);
        public List<MandatoryCourse> GetSemesterCurriculum(Guid semesterId);
        public List<MandatoryCourse> GetYearCurriculum(Guid yearId);
    }
}
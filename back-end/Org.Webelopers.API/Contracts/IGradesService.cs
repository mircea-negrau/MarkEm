
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IGradesService
    {
        public void AddGrade(short grade, Guid courseId, Guid studentId);
        public void UpdateGrade(CourseGrade newgrade);
        public void DeleteGrade(int classid, int studentid);
        public List<CourseGrade> GetStudentGrades(int studentid);
    }
}

using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IGradesService
    {
        public void AddGrade(short grade, Guid courseId, Guid studentId);
        public void UpdateGrade(Guid gradeId, short grade);
        public void DeleteGrade(Guid gradeId);
        public List<CourseGrade> GetStudentGrades(Guid studentid);
    }
}
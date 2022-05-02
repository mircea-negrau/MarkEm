using System.Collections.Generic;
using System;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Contracts
{
    public interface IGradesService
    {
        public void AddGrade(short grade, Guid courseId, Guid studentId);
        public void UpdateGrade(Guid gradeId, short grade);
        public void DeleteGrade(Guid gradeId);
        public List<MandatoryCourseGrade> GetStudentGrades(Guid studentid);
    }
}
using System;
using System.Collections.Generic;
using Org.Webelopers.Api.Models.Persistence.Grades;

namespace Org.Webelopers.Api.Contracts
{
    public interface IOptionalGradesService
    {
        public void AddGrade(short grade, Guid courseId, Guid studentId);
        public void UpdateGrade(Guid gradeId, short grade);
        public void DeleteGrade(Guid gradeId);
        public void SetGrade(Guid studentId, Guid courseId, short value);
        public List<GradesDetailDto> GetStudentGrades(Guid studentId);
    }
}
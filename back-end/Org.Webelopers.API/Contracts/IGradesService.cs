using System.Collections.Generic;
using System;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Grades;

namespace Org.Webelopers.Api.Contracts
{
    public interface IGradesService
    {
        public void AddGrade(short grade, Guid courseId, Guid studentId);
        public void UpdateGrade(Guid gradeId, short grade);
        public void DeleteGrade(Guid gradeId);
        public void SetGrade(Guid studentId, Guid courseId, short value);
        public List<ContractSemesterGrades> GetStudentGrades(Guid studentid);
        public HashSet<MandatoryCourseGrade> GetCourseGrades(Guid courseId);
        public HashSet<MandatoryCourseGrade> GetTeacherGrades(Guid teacherId);
    }
}
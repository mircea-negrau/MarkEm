
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts.Grades
{
    public interface IGradesService
    {
        public List<CourseGrade> GetStudentGrades(int studentid);
        public void AddGrade(CourseGrade grade);
        public void UpdateGrade(CourseGrade newgrade);
        public void DeleteGrade(int classid, int studentid);


    }
}
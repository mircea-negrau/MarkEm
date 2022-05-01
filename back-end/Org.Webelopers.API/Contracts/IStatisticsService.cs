using Org.Webelopers.Api.Models.Authentication;
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IStatisticsService
    {
        public Teacher GetBestResultsTeacher();
        public Course GetBestResultsCourses();
        public List<StudentsResults> GetStudentsResults();

        public List<StudentsResults> GetStudentsByGroup();

        public List<StudentsResults> GetStudentsByYear();
    }
}
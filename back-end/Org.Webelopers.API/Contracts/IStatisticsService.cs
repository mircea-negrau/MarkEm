using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semesters;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IStatisticsService
    {
        public List<GroupStudentsAverageGradeDto> GetStudentsRankingByGroup();

        public List<StudyYearStudentsAverageGradeDto> GetStudentsRankingByStudyYear();

        public List<SemesterStudentsAverageGradeDto> GetStudentsRankingBySemester();
    }
}
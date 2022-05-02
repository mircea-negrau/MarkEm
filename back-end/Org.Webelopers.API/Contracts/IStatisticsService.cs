using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Students;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IStatisticsService
    {
        public List<GroupStudentsAverageGradeDto> GetStudentsRankingByGroup();

        public List<StudentAverageGradeDto> GetStudentsRankingByStudyYear();

        public List<StudentAverageGradeDto> GetStudentsRankingBySemester();
    }
}
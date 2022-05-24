using Org.Webelopers.Api.Models.Persistence.Performance;
using Org.Webelopers.Api.Models.Persistence.Students;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IStatisticsService
    {
        public List<StudentAverageGradeDto> GetStudentsRankingByGroup(Guid groupId);

        public List<StudentAverageGradeDto> GetStudentsRankingByStudyYearByCriteria(Guid yearId, int minimumAverage);

        public List<StudentAverageGradeDto> GetStudentsRankingBySemester(Guid semesterId);
        public List<StudentPerformanceDto> GetStudentsPerformance(Filter filter, int minimumAverage);
    }
}
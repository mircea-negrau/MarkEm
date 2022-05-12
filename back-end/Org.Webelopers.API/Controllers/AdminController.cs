using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semesters;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("admin")]
    public class AdminController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public AdminController(
            IStatisticsService statisticsService
            )
        {
            _statisticsService = statisticsService;
        }

        [HttpGet("performance/byGroup")]
        public List<GroupStudentsAverageGradeDto> GetStudentsPerformanceByGroup()
        {
            return _statisticsService.GetStudentsRankingByGroup();
        }

        [HttpGet("performance/bySemester")]
        public List<SemesterStudentsAverageGradeDto> GetStudentsPerformanceBySemester()
        {
            return _statisticsService.GetStudentsRankingBySemester();
        }
        
        [HttpGet("ranking/byStudyYear")]
        public List<StudyYearStudentsAverageGradeDto> GetStudentsRankingByStudyYear()
        {
            return _statisticsService.GetStudentsRankingByStudyYear();
        }
    }
}

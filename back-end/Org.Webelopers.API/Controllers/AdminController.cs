using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semesters;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System;
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
        public IActionResult GetStudentsPerformanceByGroup([FromQuery] Guid groupId)
        {
            return Ok(_statisticsService.GetStudentsRankingByGroup(groupId));
        }

        [HttpGet("performance/bySemester")]
        public IActionResult GetStudentsPerformanceBySemester([FromQuery] Guid semesterId)
        {
            return Ok(_statisticsService.GetStudentsRankingBySemester(semesterId));
        }

        [HttpPost("performance/byStudyYear")]
        public IActionResult GetStudentsRankingByStudyYear([FromBody] StudyYearCriteriaDto dto)
        {
            return Ok(_statisticsService.GetStudentsRankingByStudyYearByCriteria(dto.YearId, dto.MinimumAverage));
        }
        [HttpGet("group/all")]
        public IActionResult GetGroups()
        {
            return Ok(_statisticsService.GetAllGroups());
        }

        [HttpGet("semester/all")]
        public IActionResult GetSemesters()
        {
            return Ok(_statisticsService.GetAllSemesters());
        }

        [HttpGet("studyYear/all")]
        public IActionResult GetStudyYears()
        {
            return Ok(_statisticsService.GetAllYears());
        }

    }
}

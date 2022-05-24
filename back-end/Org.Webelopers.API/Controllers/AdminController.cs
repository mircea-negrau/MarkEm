using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Students;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudentAverageGradeDto>))]
        public IActionResult GetStudentsPerformanceByGroup([FromQuery] Guid groupId)
        {
            return Ok(_statisticsService.GetStudentsRankingByGroup(groupId));
        }

        [HttpGet("performance/bySemester")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudentAverageGradeDto>))]
        public IActionResult GetStudentsPerformanceBySemester([FromQuery] Guid semesterId)
        {
            return Ok(_statisticsService.GetStudentsRankingBySemester(semesterId));
        }

        [HttpPost("performance/byStudyYear")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudentAverageGradeDto>))]
        public IActionResult GetStudentsRankingByStudyYear([FromBody] StudyYearCriteriaDto dto)
        {
            return Ok(_statisticsService.GetStudentsRankingByStudyYearByCriteria(dto.YearId, dto.MinimumAverage));
        }

    }
}

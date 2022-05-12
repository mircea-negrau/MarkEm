﻿using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semesters;
using Org.Webelopers.Api.Models.Persistence.Students;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

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

        public List<GroupStudentsAverageGradeDto> GetStudentsPerformanceByGroup()
        {
            return _statisticsService.GetStudentsRankingByGroup();
        }

        public List<SemesterStudentsAverageGradeDto> GetStudentsPerformanceBySemester()
        {
            return _statisticsService.GetStudentsRankingBySemester();
        }

        public List<StudyYearStudentsAverageGradeDto> GetStudentsRankingByStudyYear()
        {
            return _statisticsService.GetStudentsRankingByStudyYear();
        }
    }
}

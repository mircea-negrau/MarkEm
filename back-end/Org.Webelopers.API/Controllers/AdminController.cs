
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Authentication;
using Org.Webelopers.Api.Models.Dto;
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


        public List<StudentsResults> GetStudentsPerformanceByGroup()
        {

        }

        public List<StudentsResults> GetStudentsPerformanceByYear()
        {

        }

        public List<StudentsResults> GetStudentsWithPerformanceInRange(int minRange, int maxRange)
        {
            List<StudentsResults> studentsList = new List<StudentsResults>();
            for(int i=0;i<_statisticsService.GetStudentsResults().Count;i++)
            {
                if(_statisticsService.GetStudentsResults()[i].AverageGrade > minRange
                    && _statisticsService.GetStudentsResults()[i].AverageGrade < maxRange)
                {
                    studentsList.Add(_statisticsService.GetStudentsResults()[i]);
                }
            }
            return studentsList;
        }

        public List<StudentsResults> GetStudentRankingByPerformance()
        {
            List<StudentsResults> studentsList = _statisticsService.GetStudentsResults();
            studentsList = studentsList.OrderByDescending(x => x.AverageGrade).ToList();
            return studentsList;
        }
    }
}

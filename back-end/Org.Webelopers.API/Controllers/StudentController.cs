
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Dto;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;
        private readonly IContractService _contractService;
        private readonly ICurriculumService _curriculumService;
        //private readonly IOptionalCourseService _optionalCourseService;
        private readonly IGradesService _gradeService;
        public StudentController(
            IConfiguration configuration,
            ILogger<AuthController> logger,
            IContractService contractService,
            ICurriculumService curriculumService,
            //IOptionalCourseService optionalService,
            IGradesService gradeService
            )
        {
            _configuration = configuration;
            _logger = logger;
            _contractService = contractService;
            _curriculumService = curriculumService;
            //_optionalCourseService = optionalService;
            _gradeService = gradeService;
        }


        [HttpPost("enroll")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult EnrollStudent([FromBody] EnrollDto enroll)
        {
            _contractService.EnrollStudent(enroll.StudentID, enroll.YearId);
            return Ok();
        }

        // Dummy method
        [HttpPost("dummy")]
        [Authorize(Roles = "Student")]
        public IActionResult Dummy([FromBody] GradeDto gradeDto)
        {
            var authorization = HttpContext.Request.Headers["Authorization"];
            var token = Verify(authorization);
            Guid studentId = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
            _logger.LogInformation(authorization.ToString());
            try
            {
                _gradeService.AddGrade(gradeDto.Grade, gradeDto.CourseId, studentId);
                return Ok(new { message = "Successful" });
            }
            catch (Exception)
            {
                return NotFound("Student or course ID is invalid!");
            }
        }

        private JwtSecurityToken Verify(string jwt)
        {
            if (jwt.Contains("Bearer"))
            {
                jwt = jwt.Split("Bearer ")[1];
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var secureKey = _configuration["JwtConfig:Secret"];
            byte[] key = Encoding.ASCII.GetBytes(secureKey);
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false
            }, out SecurityToken validatedToken);
            return (JwtSecurityToken)validatedToken;
        }

        [HttpPost("disenroll")]
        [Authorize(Roles = "Student")]
        public void DisenrollStudent([FromBody] Guid contractId)
        {
            _contractService.RemoveContract(contractId);
        }

        [HttpGet("contracts/number")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GerNumberOfContracts([FromBody] Guid studentid)
        {
            return Ok(_contractService.GetNumberOfContracts(studentid));
        }

        //// Implement so it works like courses/{courseId}
        [HttpGet("courses/contract")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetContractClasses([FromBody] Guid contractId)
        {
            return Ok(_contractService.GetContractCourses(contractId));
        }

        [HttpPost("sign")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult SignContract([FromBody] Guid contractid)
        {
            _contractService.SignContract(contractid);
            return Ok();
        }

        [HttpGet("optionalCourses/all")]
        //public List<Course> GetOptionalCourses()
        //{
        //    return _optionalCourseService.getOptionalCourses();
        //}

        ///* public void SetOptionalCoursesPreference(int studentid, List<OptionalCoursePreference> preferences)
        // {
        //    //  TODO
        // }*/

        [HttpGet("getgrades")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetGrades([FromBody] Guid studentId)
        {
            return Ok(_gradeService.GetStudentGrades(studentId));
        }

        [HttpGet("getyearcourses")]
        public IActionResult GetYearCourses([FromBody] Guid yearId)
        {
            return Ok(_curriculumService.GetYearCurriculum(yearId));
        }
    }
}

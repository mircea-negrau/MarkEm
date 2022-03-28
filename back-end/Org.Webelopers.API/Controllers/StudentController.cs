
using Microsoft.AspNetCore.Authorization;
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
        //private readonly IContractService _contractService;
        //private readonly ICurriculumService _curriculumService;
        //private readonly IOptionalCourseService _optionalCourseService;
        private readonly IGradesService _gradeService;
        public StudentController(
            IConfiguration configuration,
            ILogger<AuthController> logger,
            //IContractService contractService,
            //ICurriculumService curriculumService,
            //IOptionalCourseService optionalService,
            IGradesService gradeService
            )
        {
            _configuration = configuration;
            _logger = logger;
            //_contractService = contractService;
            //_curriculumService = curriculumService;
            //_optionalCourseService = optionalService;
            _gradeService = gradeService;
        }


        //[HttpPost("enroll")]
        //[Authorize(Roles = "Student")]
        //public StudyContract EnrollStudent(StudyYear studyyear, Student student)
        //{
        //    var contract = _contractService.EnrollStudent(studyyear, student);
        //    return contract;
        //}

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

        //[HttpPost("disenroll")]
        //public void DisenrollStudent(int studentid)
        //{
        //    _contractService.DisenrollStudent(studentid);
        //}

        //[HttpGet("contracts/number")]
        //public int GerNumberOfContracts(int studentid)
        //{
        //    return _contractService.GetNumberOfContracts(studentid);
        //}

        //// Implement so it works like courses/{courseId}
        ////[HttpGet("courses")]
        ////public List<Course> GetContractClasses(int contractid)
        ////{
        ////    return _contractService.GetContractClasses(contractid);
        ////}

        //[HttpGet("courses/all")]
        //public List<Course> GetAllEnrolledClasses(int studentid)
        //{
        //    return _contractService.GetAllStudentClasses(studentid);
        //}
        //[HttpPost("sign")]
        //public void SignContract(int studentid, int contractid)
        //{
        //    _contractService.SignContract(studentid, contractid);
        //}
        //[HttpGet("optionalCourses/all")]
        //public List<Course> GetOptionalCourses()
        //{
        //    return _optionalCourseService.getOptionalCourses();
        //}

        ///* public void SetOptionalCoursesPreference(int studentid, List<OptionalCoursePreference> preferences)
        // {
        //    //  TODO
        // }*/
        //[HttpGet("getgrades")]
        //public List<CourseGrade> GetGrades(int studentid)
        //{
        //    return _gradeService.GetStudentGrades(studentid);
        //}
        //[HttpGet("getyearcourses")]
        //public List<Course> GetYearCourses(int year)
        //{
        //    return _curriculumService.GetYearCurriculum(year);
        //}
    }
}

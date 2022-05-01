
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Dto;
using System;
using System.Linq;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IContractService _contractService;
        private readonly ICurriculumService _curriculumService;
        private readonly IOptionalCourseService _optionalCourseService;
        private readonly IGradesService _gradeService;
        private readonly IAuthTokenService _authTokenService;

        public StudentController(
            ILogger<AuthController> logger,
            IContractService contractService,
            ICurriculumService curriculumService,
            IOptionalCourseService optionalService,
            IGradesService gradeService,
            IAuthTokenService authTokenService
            )
        {
            _logger = logger;
            _contractService = contractService;
            _curriculumService = curriculumService;
            _optionalCourseService = optionalService;
            _gradeService = gradeService;
            _authTokenService = authTokenService;
        }


        [HttpPost("enroll")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EnrollStudent([FromBody] EnrollDto enroll)
        {
            try
            {
                _contractService.EnrollStudent(enroll.StudentID, enroll.YearId);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

            return Ok();
        }

        // Dummy method
        [HttpPost("dummy")]
        [Authorize(Roles = "Student")]
        public IActionResult Dummy([FromBody] GradeDto gradeDto)
        {
            var authorization = HttpContext.Request.Headers["Authorization"];
            var token = _authTokenService.ValidateAuthToken(authorization);
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

        [HttpPost("disenroll")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DisenrollStudent([FromQuery] Guid contractId)
        {
            try
            {
                _contractService.RemoveContract(contractId);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

            return Ok();

        }

        [HttpGet("contracts/number")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GerNumberOfContracts([FromBody] Guid studentid)
        {
            try
            {
                return Ok(_contractService.GetNumberOfContracts(studentid));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        //// Implement so it works like courses/{courseId}
        [HttpGet("courses/contract")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetContractClasses([FromBody] Guid contractId)
        {
            try
            {
                var response = _contractService.GetContractCourses(contractId);
                return response != null
                    ? Ok(_contractService.GetContractCourses(contractId))
                    : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost("sign")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult SignContract([FromBody] Guid contractid)
        {
            try
            {
                _contractService.SignContract(contractid);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }


            return Ok();
        }

        [HttpGet("optionalCourses/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOptionalCourses()
        {
            try
            {
                return Ok(_optionalCourseService.GetOptionalCourses());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }

        [HttpPost("optionalCourses/setPreference")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SetOptionalCoursesPreference([FromBody] CoursePreferenceDto dto)
        {
            try
            {
                bool response = _optionalCourseService.SetStudentOptionalCoursesPreference(dto.Preference, dto.ContractId, dto.OptionalCourseId);
                return response
                    ? Ok()
                    : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

        }

        [HttpGet("grades/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGrades([FromBody] Guid studentId)
        {
            try
            {
                return Ok(_gradeService.GetStudentGrades(studentId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }

        [HttpGet("courses/year")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetYearCourses([FromBody] Guid yearId)
        {
            try
            {
                return Ok(_curriculumService.GetYearCurriculum(yearId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }

        [HttpGet("contracts/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStudentContracts([FromQuery] Guid studentId)
        {
            try
            {
                return Ok(_contractService.GetStudentContractsEnriched(studentId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }

        [HttpGet("faculties/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllFaculties()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }
    }
}

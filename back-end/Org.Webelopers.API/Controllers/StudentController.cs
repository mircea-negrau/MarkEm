
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using Org.Webelopers.Api.Models.Persistence.Grades;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IContractService _contractService;
        private readonly IGradesService _gradeService;
        private readonly IAuthTokenService _authTokenService;
        private readonly IOptionalCourseService _optionalCourseService;

        public StudentController(
            ILogger<AuthController> logger,
            IContractService contractService,
            IGradesService gradeService,
            IAuthTokenService authTokenService,
            IOptionalCourseService optionalCourseService
            )
        {
            _logger = logger;
            _contractService = contractService;
            _gradeService = gradeService;
            _authTokenService = authTokenService;
            _optionalCourseService = optionalCourseService;
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
                _contractService.EnrollStudent(enroll.StudentID, enroll.SpecialisationId);
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
            var token = _authTokenService.ParseAuthToken(authorization);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
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

        [HttpPost("setAllPreferences")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SetOptionalCoursesPreferences([FromBody] OptionalCoursePreferenceDto dto)
        {
            try
            {
                _optionalCourseService.SetCoursesPreferences(dto.ContractId, dto.CoursesIds);
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
            }

        }

        [HttpPost("sign")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult SignContract([FromQuery] Guid contractId)
        {
            try
            {
                _contractService.SignContract(contractId);
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


        [HttpGet("grades/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ContractSemesterGrades>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGrades([FromQuery] Guid studentId)
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



        [HttpGet("contracts/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ContractEnriched>))]
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

    }
}

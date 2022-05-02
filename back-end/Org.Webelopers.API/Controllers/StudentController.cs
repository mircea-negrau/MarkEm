
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
        private readonly IFacultyService _facultyService;
        private readonly IAuthTokenService _authTokenService;

        public StudentController(
            ILogger<AuthController> logger,
            IContractService contractService,
            ICurriculumService curriculumService,
            IOptionalCourseService optionalService,
            IGradesService gradeService,
            IAuthTokenService authTokenService,
            IFacultyService facultyService
            )
        {
            _logger = logger;
            _contractService = contractService;
            _curriculumService = curriculumService;
            _optionalCourseService = optionalService;
            _gradeService = gradeService;
            _authTokenService = authTokenService;
            _facultyService = facultyService;
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

        [HttpGet("optionalCourses/all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOptionalCourses([FromBody] Guid studentContractSemesterId)
        {
            try
            {
                // TODO: test that it works
                var studySemester = _curriculumService.GetStudySemester(studentContractSemesterId);
                return Ok(_optionalCourseService.FilterCourses(course => course.SemesterId == studySemester.StudyYearId));
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
                // TODO: 1. change the CoursePreferenceDto.ContractId to studentId (or which one?)
                // TODO: 2. maybe add some more catch clauses, and return more specific responses based on that
                _optionalCourseService.SetCoursePreference(dto.ContractId, dto.OptionalCourseId, dto.Preference);
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
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
                return Ok(_facultyService.GetAllFacultiesDetails());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }

        [HttpGet("faculties/specialisations")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllFaculties([FromQuery] Guid facultyId, [FromQuery] Guid degreeId)
        {
            try
            {
                return Ok(_facultyService.GetFacultySpecialisations(facultyId, degreeId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }
    }
}

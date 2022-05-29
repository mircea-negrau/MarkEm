using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Types;
using System;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.Persistence.Courses;
using Org.Webelopers.Api.Models.Persistence.Grades;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;
using Org.Webelopers.Api.Models.Dto;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("optionals")]
    [Authorize(Roles = "Teacher")]
    [Produces(MimeTypes.Json)]
    public class OptionalsController : Controller
    {
        #region FieldsAndConstructor

        private readonly ILogger<AuthController> _logger;
        private readonly IAuthTokenService _authTokenService;
        private readonly IOptionalCourseService _optionalCourseService;
        private readonly IOptionalGradesService _optionalGradesService;

        public OptionalsController(ILogger<AuthController> logger,
            IAuthTokenService authTokenService, 
            IOptionalCourseService optionalCourseService, 
            IOptionalGradesService optionalGradesService
        )
        {
            _logger = logger;
            _authTokenService = authTokenService;
            _optionalCourseService = optionalCourseService;
            _optionalGradesService = optionalGradesService;
        }

        #endregion


        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherCoursesResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCourses()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                var courses = await _optionalCourseService.GetEnrichedCoursesByTeacher(teacherId);
                return Ok(courses);
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet("all/for-teacher-optionals-page")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherOptionals))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOptionalsForTeacherOptionalsPage()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                return Ok(await _optionalCourseService.GetEnrichedCoursesForTeacherOptionalsPage(teacherId));
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpGet("optional/{courseId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherCourseDetailDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetCourseById([FromRoute] Guid courseId)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                return Ok(_optionalCourseService.GetEnrichedCourseById(courseId));
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (InvalidCourseTeacher e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                Console.Error.WriteLine($"e.StackTrace: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("optional/{courseId}/gradeStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GradeStudent([FromRoute] Guid courseId, [FromBody] SetGradeDto setGradeDto)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                _optionalGradesService.SetGrade(setGradeDto.StudentId, courseId, setGradeDto.Value);
                return Ok(new {message = "success"});
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (InvalidCourseTeacher e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (NullReferenceException e)
            {
                return NotFound(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet("optional/{courseId}/students")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherOptionalStudentsWithGradeResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOptionalStudentsWithGrade([FromRoute] Guid courseId)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                return Ok(await _optionalCourseService.GetStudentsWithGrade(courseId));
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (InvalidCourseTeacher e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new { message = e.Message });
            }
        }

        [HttpPost("propose")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Propose([FromBody] ProposedCoursesIds proposedCoursesIds)
        {
            try
            {
                ValidateCourseTeacher(proposedCoursesIds.First, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                ValidateCourseTeacher(proposedCoursesIds.Second, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                _optionalCourseService.Propose(proposedCoursesIds.First, proposedCoursesIds.Second);
                return Ok(new {message = "success"});
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (InvalidCourseTeacher e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }
        
        [HttpGet("proposed")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProposedCoursesIds))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProposed()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                return Ok(_optionalCourseService.GetProposed(teacherId));
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost("setPreference")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SetOptionalCoursesPreference([FromBody] CoursePreferenceDto dto)
        {
            try
            {
                _optionalCourseService.SetCoursePreference(dto.ContractId, dto.OptionalCourseId, dto.Preference);
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
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
                _optionalCourseService.SetCoursesPreferences(dto.contractId, dto.coursesIds);
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
            }

        }

        #region PrivateMethods

        private void ValidateCourseTeacher(Guid courseId, Guid teacherId)
        {
            if (!_optionalCourseService.IsCourseTaughtBy(courseId, teacherId))
            {
                throw new InvalidCourseTeacher($"course {courseId} doesn't belong to teacher {teacherId}");
            }
        }

        #endregion

        #region Exceptions

        private class InvalidCourseTeacher : Exception
        {
            public InvalidCourseTeacher(string message) : base(message)
            {
            }
        }

        #endregion
    }
}

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
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;

namespace Org.Webelopers.Api.Controllers
{
    [Route("teacher")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class TeacherController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ICourseService _courseService;
        private readonly IOptionalCourseService _optionalCourseService;
        private readonly IGradesService _gradesService;
        private readonly IOptionalGradesService _optionalGradesService;
        private readonly IAuthTokenService _authTokenService;

        public TeacherController(ILogger<AuthController> logger, ICourseService courseService, IOptionalCourseService optionalCourseService, IGradesService gradesService, IOptionalGradesService optionalGradesService, IAuthTokenService authTokenService)
        {
            _logger = logger;
            _courseService = courseService;
            _optionalCourseService = optionalCourseService;
            _gradesService = gradesService;
            _optionalGradesService = optionalGradesService;
            _authTokenService = authTokenService;
        }

        [HttpGet("courses/all")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherCoursesResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCourses([FromQuery] string teacherId)
        {
            try
            {
                var courses = await _courseService.GetEnrichedCoursesByTeacher(Guid.Parse(teacherId));
                var optionalCourses = await _optionalCourseService.GetEnrichedCoursesByTeacher(Guid.Parse(teacherId));
                courses.Courses.AddRange(optionalCourses.Courses);
                return Ok(courses);
            }
            catch (FormatException e)
            {
                _logger.LogError(e.Message);
                return BadRequest(new { message = e.Message });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return NotFound(new { message = e.Message });
            }
        }

        [HttpGet("courses/courseGroups/addSamples")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSamplesForGetCourseGroups()
        {
            try
            {
                _courseService.AddSamplesForGetCourseGroups();
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
    
        [HttpGet("courses/courseGroups/{courseId}")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherGroupsResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCourseGroups([FromRoute] Guid courseId)
        {
            try
            {
                return Ok(await _courseService.GetCourseGroups(courseId));
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }
        
        [HttpGet("courses/optionalStudents/addSamples")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSamplesForGetOptionalStudentsWithGrade()
        {
            try
            {
                _optionalCourseService.AddSamplesForGetOptionalStudentsWithGrade();
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
        
        [HttpGet("courses/optionalStudents/{courseId}")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherOptionalStudentsWithGradeResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOptionalStudentsWithGrade([FromRoute] Guid courseId)
        {
            try
            {
                return Ok(await _optionalCourseService.GetStudentsWithGrade(courseId));
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new { message = e.Message });
            }
        }

        [HttpPost("courses/gradeStudent")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GradeStudent([FromBody] SetGradeDto setGradeDto)
        {
            try
            {
                if (_courseService.Exists(setGradeDto.CourseId))
                {
                    _gradesService.SetGrade(setGradeDto.StudentId, setGradeDto.CourseId, setGradeDto.Value);
                    return Ok(new {message = "success"});
                }
                if (_optionalCourseService.Exists(setGradeDto.CourseId))
                {
                    _optionalGradesService.SetGrade(setGradeDto.StudentId, setGradeDto.CourseId, setGradeDto.Value);
                    return Ok(new {message = "success"});
                }
                _logger.LogError($"course with id {setGradeDto.CourseId} not found");
                return NotFound($"course with id {setGradeDto.CourseId} not found");
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet("optionals")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherOptionals))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOptionals()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                return Ok(await _optionalCourseService.GetEnrichedCoursesForTeacherOptionalsPage(teacherId));
            }
            catch (IAuthTokenService.UidClaimNotFound)
            {
                return BadRequest(new {message = "UID claim not found"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
        
        [HttpGet("optionals/proposed")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProposedCoursesIds))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProposed()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                return Ok(_optionalCourseService.GetProposed(teacherId));
            }
            catch (IAuthTokenService.UidClaimNotFound)
            {
                return BadRequest(new {message = "UID claim not found"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost("optionals/propose")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Propose([FromBody] ProposedCoursesIds proposedCoursesIds)
        {
            try
            {
                _optionalCourseService.Propose(proposedCoursesIds.First, proposedCoursesIds.Second);
                return Ok(new {message = "success"});
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new { message = e.Message });
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new { message = e.Message });
            }
        }
    }
}

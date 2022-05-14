using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Types;
using System;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.Persistence.Grades;

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

        public TeacherController(ILogger<AuthController> logger, ICourseService courseService, IOptionalCourseService optionalCourseService, IGradesService gradesService, IOptionalGradesService optionalGradesService)
        {
            _logger = logger;
            _courseService = courseService;
            _optionalCourseService = optionalCourseService;
            _gradesService = gradesService;
            _optionalGradesService = optionalGradesService;
        }

        [HttpGet("courses/all")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
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
                    return Ok("success");
                }
                if (_optionalCourseService.Exists(setGradeDto.CourseId))
                {
                    _optionalGradesService.SetGrade(setGradeDto.StudentId, setGradeDto.CourseId, setGradeDto.Value);
                    return Ok("success");
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
        
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Types;
using System;
using System.Threading.Tasks;

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

        public TeacherController(ILogger<AuthController> logger, ICourseService courseService, IOptionalCourseService optionalCourseService)
        {
            _logger = logger;
            _courseService = courseService;
            _optionalCourseService = optionalCourseService;
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

        [HttpGet("courses/courseGroupsAddSamples")]
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
    
        [HttpGet("courses/courseGroups")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCourseGroups([FromQuery] Guid courseId)
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
        
        [HttpGet("courses/optionalStudentsAddSamples")]
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
        
        [HttpGet("courses/optionalStudents")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetOptionalStudentsWithGrade([FromQuery] Guid courseId)
        {
            try
            {
                return Ok(await _optionalCourseService.GetStudentsWithGrade(courseId));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return NotFound(new { message = e.Message });
            }
        }
    }
}

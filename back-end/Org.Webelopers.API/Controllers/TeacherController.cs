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

        public TeacherController(ILogger<AuthController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpGet("courses/all")]
        [Authorize(Roles = "Teacher")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllMandatoryCourses([FromQuery] string teacherId)
        {
            try
            {
                var courses = await _courseService.GetEnrichedMandatoryCoursesByTeacher(Guid.Parse(teacherId));
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
    }
}

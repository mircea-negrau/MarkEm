using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using Org.Webelopers.Api.Models.Types;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("testing")]
    [Produces(MimeTypes.Json)]
    public class TestingController : Controller
    {
        #region FieldsAndConstructor

        private readonly ILogger<AuthController> _logger;
        private readonly IFacultyService _facultyService;
        private readonly ICourseService _courseService;
        private readonly ITestingService _testingService;

        public TestingController(ILogger<AuthController> logger, IFacultyService facultyService, ICourseService courseService, ITestingService testingService)
        {
            _logger = logger;
            _facultyService = facultyService;
            _courseService = courseService;
            _testingService = testingService;
        }

        #endregion

        [HttpPost("add/enrollments/{courseId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddEnrollmentsToCourse(Guid courseId)
        {
            try
            {
                _logger.LogInformation("AddEnrollmentsToCourse() start");
                _testingService.AddEnrollmentsToCourse(courseId);
                string result = $"AddEnrollmentsToCourse() finish: added enrollments to course {courseId}";
                _logger.LogInformation(result);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                // _logger.LogError($"e.Message: {e.StackTrace}");
                Console.Error.WriteLine($"e.StackTrace: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("add/groups")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSamplesForGetCourseGroups()
        {
            try
            {
                _testingService.AddSamplesForGetCourseGroups();
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("add/specializations/{number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddRandomSpecializations([FromRoute] int number)
        {
            try
            {
                var result = _testingService.AddRandomSpecializations(number);
                _logger.LogInformation($"created {result.Count} specializations");
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.Message: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
        
        [HttpPost("add/students-with-grades-to-optional/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddStudentsWithGradesToOptional()
        {
            try
            {
                _testingService.AddStudentsWithGradesToOptional();
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
        
        [HttpPost("add/students-with-grades-to-optional/{courseId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddStudentsWithGradesToOptional(Guid courseId)
        {
            try
            {
                _testingService.AddStudentsWithGradesToOptional(courseId);
                return Ok(new {message = "success"});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpGet("faculties")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HashSet<Faculty>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFaculties()
        {
            try
            {
                var result = _facultyService.GetFaculties();
                _logger.LogInformation($"found {result.Count} faculties");
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.Message: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpGet("faculties/{facultyId}/teachers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HashSet<Teacher>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFacultyTeachers([FromRoute] Guid facultyId)
        {
            try
            {
                _logger.LogInformation($"chief of faculty {facultyId} is {_facultyService.GetFacultyIdBy(_facultyService.GetChiefId(facultyId))}");
                var result = _facultyService.GetFacultyTeachers(facultyId);
                _logger.LogInformation($"faculty {facultyId} has {result.Count} teachers");
                return Ok(result);
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                return NotFound(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.Message: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpGet("faculties/{facultyId}/courses")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HashSet<MandatoryCourse>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFacultyCourses([FromRoute] Guid facultyId)
        {
            try
            {
                var result = _courseService.GetFacultyCourses(facultyId);
                _logger.LogInformation($"faculty {facultyId} has {result.Count} courses");
                return Ok(result);
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                return NotFound(new {message = e.Message});
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.Message: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpGet("faculties/{facultyId}/chief-teachers-with-courses-info")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChiefTeachersWithCoursesInfo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetChiefChiefTeachersWithCoursesInfo(Guid facultyId)
        {
            try
            {
                return Ok(await _courseService.GetChiefChiefTeachersWithCoursesInfo(facultyId));
            }
            catch (Exception e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.Message: {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
    }
}
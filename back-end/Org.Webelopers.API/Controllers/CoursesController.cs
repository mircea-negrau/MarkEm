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

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("courses")]
    [Produces(MimeTypes.Json)]
    [Authorize(Roles = "Teacher")]
    public class CoursesController : Controller
    {
        #region FieldsAndConstructor

        private readonly ILogger<AuthController> _logger;
        private readonly IAuthTokenService _authTokenService;
        private readonly ICourseService _courseService;
        private readonly IGradesService _gradesService;
        private readonly ICurriculumService _curriculumService;
        private readonly IFacultyService _facultyService;

        public CoursesController(ILogger<AuthController> logger,
            ICourseService courseService,
            IGradesService gradesService,
            IAuthTokenService authTokenService,
            ICurriculumService curriculumService, 
            IFacultyService facultyService)
        {
            _logger = logger;
            _authTokenService = authTokenService;
            _courseService = courseService;
            _gradesService = gradesService;
            _curriculumService = curriculumService;
            _facultyService = facultyService;
        }

        #endregion

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherCoursesResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCourses()
        {
            try
            {
                var teacherId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                var courses = await _courseService.GetEnrichedCoursesByTeacher(teacherId);
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
        
        [HttpGet("all/for-chief-teachers-disciplines-page")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChiefTeachersWithCoursesInfo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Policy = "ChiefOfDepartmentRequirement")]
        public async Task<IActionResult> GetOptionalsChiefView()
        {
            try
            {
                var chiefId = _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]);
                var facultyId = _facultyService.GetFacultyIdBy(chiefId);
                return Ok(await _courseService.GetChiefChiefTeachersWithCoursesInfo(facultyId));
            }
            catch (IAuthTokenService.UidClaimNotFound e)
            {
                return BadRequest(new {message = e.Message});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
    
        [HttpGet("course/{courseId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherCourseDetailDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetCourseById([FromRoute] Guid courseId)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                return Ok(_courseService.GetEnrichedCourseById(courseId));
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

        [HttpPost("course/{courseId}/gradeStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GradeStudent([FromRoute] Guid courseId, [FromBody] SetGradeDto setGradeDto)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                _gradesService.SetGrade(setGradeDto.StudentId, courseId, setGradeDto.Value);
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
    
        [HttpGet("course/{courseId}/groups")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TeacherGroupsResponse))]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCourseGroups([FromRoute] Guid courseId)
        {
            try
            {
                ValidateCourseTeacher(courseId, _authTokenService.GetAccountId(HttpContext.Request.Headers["Authorization"]));
                return Ok(await _courseService.GetCourseGroups(courseId));
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

        [HttpGet("year")]
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

        #region PrivateMethods
        
        private void ValidateCourseTeacher(Guid courseId, Guid teacherId)
        {
            if (!_courseService.IsCourseTaughtBy(courseId, teacherId))
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

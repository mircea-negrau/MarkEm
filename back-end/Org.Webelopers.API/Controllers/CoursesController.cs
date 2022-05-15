﻿using Microsoft.AspNetCore.Authorization;
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

        public CoursesController(ILogger<AuthController> logger,
            ICourseService courseService,
            IGradesService gradesService,
            IAuthTokenService authTokenService
        )
        {
            _logger = logger;
            _authTokenService = authTokenService;
            _courseService = courseService;
            _gradesService = gradesService;
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

        [HttpPost("courseGroupsAddSamples")]
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

        private void ValidateCourseTeacher(Guid courseId, Guid teacherId)
        {
            if (!_courseService.IsCourseTaughtBy(courseId, teacherId))
            {
                throw new InvalidCourseTeacher($"course {courseId} doesn't belong to teacher {teacherId}");
            }
        }

        private class InvalidCourseTeacher : Exception
        {
            public InvalidCourseTeacher(string message) : base(message)
            {
            }
        }
    }
}
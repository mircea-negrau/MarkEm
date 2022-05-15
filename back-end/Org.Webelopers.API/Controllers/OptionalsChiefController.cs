using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("optionals")]
    [Authorize(Roles = "Teacher")]
    [Authorize(Policy = "ChiefOfDepartmentRequirement")]
    public class OptionalsChiefController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        // private readonly IAuthTokenService _authTokenService;
        private readonly IOptionalCourseService _optionalCourseService;

        public OptionalsChiefController(ILogger<AuthController> logger, 
            // IAuthTokenService authTokenService, 
            IOptionalCourseService optionalCourseService)
        {
            _logger = logger;
            // _authTokenService = authTokenService;
            _optionalCourseService = optionalCourseService;
        }

        [HttpPost("optional/{courseId}/approve")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ApproveOptional([FromRoute] Guid courseId)
        {
            try
            {
                // TODO: ValidateCourseChief(Guid courseId, Guid chiefId) FOR ALL methods with the courseId in the route
                _optionalCourseService.ApproveCourse(courseId);
                _logger.LogInformation($"approved optional {courseId}");
                return Ok(new {message = "success"});
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new {message = $"{e.Message} course with id {courseId} not found"});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("optional/{courseId}/disapprove")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DisapproveOptional([FromRoute] Guid courseId)
        {
            try
            {
                _optionalCourseService.DisapproveCourse(courseId);
                _logger.LogInformation($"disapproved optional {courseId}");
                return Ok(new {message = "success"});
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new {message = $"{e.Message} course with id {courseId} not found"});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("optional/{courseId}/setCapacity")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult SetOptionalCapacity([FromRoute] Guid courseId, [FromBody] int capacity)
        {
            try
            {
                _optionalCourseService.SetCourseCapacity(courseId, capacity);
                _logger.LogInformation($"set optional {courseId} capacity to {capacity}");
                return Ok(new {message = "success"});
            }
            catch (NullReferenceException e)
            {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return NotFound(new {message = $"{e.Message} course with id {courseId} not found"});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
        

        [HttpPost("assignAddSamples")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSamplesForAssignOptionals()
        {
            try
            {
                _optionalCourseService.AddSamplesForAssignCoursesToStudents();  
                return Ok(new {message = "success"});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }

        [HttpPost("assign")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AssignOptionals()
        {
            try
            {
                _logger.LogInformation($"Assigned {_optionalCourseService.AssignCoursesToStudents(true)} semester contracts");
                return Ok(new {message = "success"});
            }
            catch (Exception e) {
                _logger.LogError($"e.Message: {e.Message}");
                _logger.LogError($"e.StackTrace = {e.StackTrace}");
                return BadRequest(new {message = e.Message});
            }
        }
    }
}
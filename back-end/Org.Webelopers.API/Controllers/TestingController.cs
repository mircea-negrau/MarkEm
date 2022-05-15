using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.DbEntities;
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

        public TestingController(ILogger<AuthController> logger, IFacultyService facultyService)
        {
            _logger = logger;
            _facultyService = facultyService;
        }

        #endregion

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

        [HttpGet("faculty/{facultyId}/teachers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HashSet<Teacher>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        }
        
    }
}
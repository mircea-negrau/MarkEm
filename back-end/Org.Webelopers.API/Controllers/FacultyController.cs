
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Faculties;
using Org.Webelopers.Api.Models.Persistence.Specialization;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("faculty")]
    public class FacultyController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IFacultyService _facultyService;

        public FacultyController(
            ILogger<AuthController> logger,
            IFacultyService facultyService
            )
        {
            _logger = logger;
            _facultyService = facultyService;
        }


        [HttpGet("all")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FacultyDetailDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllFaculties()
        {
            try
            {
                return Ok(_facultyService.GetAllFacultiesDetails());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }

        [HttpGet("specialisations")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SpecialisationDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllFaculties([FromQuery] Guid facultyId, [FromQuery] Guid degreeId)
        {
            try
            {
                return Ok(_facultyService.GetFacultySpecialisations(facultyId, degreeId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }
    }
}

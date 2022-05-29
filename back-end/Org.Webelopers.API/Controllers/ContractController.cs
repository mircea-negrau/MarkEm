
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("contract")]
    public class ContractController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IContractService _contractService;
        private readonly IOptionalCourseService _optionalCourseService;

        public ContractController(
            ILogger<AuthController> logger,
            IContractService contractService,
            IOptionalCourseService optionalService
            )
        {
            _logger = logger;
            _contractService = contractService;
            _optionalCourseService = optionalService;
        }

        [HttpGet("courses")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<MandatoryCourse>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetContractClasses([FromQuery] Guid contractId)
        {
            try
            {
                var response = _contractService.GetContractCourses(contractId);
                return response != null
                    ? Ok(response)
                    : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet("semesterContract")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SemesterContractDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetSemesterContractsByContractId([FromQuery] Guid contractId)
        {
            try
            {
                var response = _contractService.GetYearlyContractAllSemesterContracts(contractId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet("optionalCourses")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OptionalCourseDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOptionalCoursesByContract([FromQuery] Guid contractId)
        {
            try
            {
                var courses = _optionalCourseService.GetOptionalCoursesByContractId(contractId);
                return Ok(courses);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }

        [HttpGet("optionalCourses/bySemesterContract")]
        [Authorize(Roles = "Student")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OptionalCourseDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOptionalCoursesBySemesterContract([FromQuery] Guid semesterContractId)
        {
            try
            {
                var courses = _optionalCourseService.GetOptionalCoursesBySemesterContractId(semesterContractId);
                return Ok(courses);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }
        }


    }
}

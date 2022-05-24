using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Semester;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("semester")]
    public class SemesterController : Controller
    {
        private readonly ISemesterService _semesterService;
        public SemesterController(
            ISemesterService semesterService
            )
        {
            _semesterService = semesterService;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SemesterDto>))]
        public IActionResult GetSemesters()
        {
            return Ok(_semesterService.GetAllSemesters());
        }

    }
}

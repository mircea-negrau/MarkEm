using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("year")]
    public class YearController : Controller
    {
        private readonly IYearService _yearService;
        public YearController(
            IYearService yearService
            )
        {
            _yearService = yearService;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudyYearDto>))]
        public IActionResult GetYears()
        {
            return Ok(_yearService.GetAllYears());
        }

    }
}

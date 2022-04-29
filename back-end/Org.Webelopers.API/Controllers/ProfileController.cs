using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Types;
using System;

namespace Org.Webelopers.Api.Controllers
{
    [Route("profile")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class ProfileController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IProfileService _profileService;

        public ProfileController(ILogger<AuthController> logger, IProfileService profileService)
        {
            _logger = logger;
            _profileService = profileService;
        }

        [HttpGet("{username}")]
        [Authorize(Roles = "Student,Teacher,Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProfileByUsername([FromRoute] string username)
        {
            try
            {
                return Ok(_profileService.GetPublicProfileByUsername(username));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return NotFound(new { message = e.Message });
            }
        }
    }
}

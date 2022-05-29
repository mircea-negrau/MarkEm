using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Profiles;
using Org.Webelopers.Api.Models.Types;
using System;
using System.IO;
using System.Linq;
using static BCrypt.Net.BCrypt;

namespace Org.Webelopers.Api.Controllers
{
    [Route("profile")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class ProfileController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IProfileService _profileService;
        private readonly IAuthTokenService _authTokenService;

        public ProfileController(ILogger<AuthController> logger,
            IProfileService profileService,
            IAuthTokenService authTokenService
            )
        {
            _logger = logger;
            _authTokenService = authTokenService;
            _profileService = profileService;
        }

        [HttpGet("{username}")]
        [Authorize(Roles = "Student,Teacher,Admin")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProfileResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProfileByUsername([FromRoute] string username)
        {
            try
            {
                return Ok(_profileService.GetProfileByUsername(username));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return NotFound(new { message = e.Message });
            }
        }

        [HttpPost("picture/upload"), DisableRequestSizeLimit]
        [Authorize(Roles = "Student,Teacher,Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UploadProfilePicture()
        {
            try
            {
                var authorization = HttpContext.Request.Headers["Authorization"];
                var token = _authTokenService.ParseAuthToken(authorization);
                Guid userId = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "uid")?.Value);

                var file = Request.Form.Files[0];
                if (file.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        byte[] fileBytes = ms.ToArray();
                        _profileService.SaveProfilePicture(userId, fileBytes);
                    }
                    return Ok("Profile picture saved.");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e}");
            }
        }

        [HttpPost("passwordChange")]
        [Authorize(Roles = "Student,Teacher,Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdatePassword([FromBody] PasswordChangeRequestDto request)
        {
            try
            {
                var authorization = HttpContext.Request.Headers["Authorization"];
                var token = _authTokenService.ParseAuthToken(authorization);
                Guid userId = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "uid")?.Value);
                string passwordHash = HashPassword(request.Password);
                _profileService.UpdatePassword(userId, passwordHash);
                return Ok("Password saved.");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e}");
            }
        }

        [HttpPost("setAbout")]
        [Authorize(Roles = "Student,Teacher,Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateAbout([FromBody] AboutChangeRequestDto request)
        {
            try
            {
                var authorization = HttpContext.Request.Headers["Authorization"];
                var token = _authTokenService.ParseAuthToken(authorization);
                Guid userId = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "uid")?.Value);
                _profileService.UpdateAbout(userId, request.About);
                return Ok("Password saved.");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e}");
            }
        }

        [HttpGet("picture"), DisableRequestSizeLimit]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProfilePicture([FromQuery] string userId)
        {
            try
            {
                byte[] profilePicture = _profileService.GetProfilePictureById(Guid.Parse(userId));
                return Ok(profilePicture);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e}");
            }
        }
    }
}

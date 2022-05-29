using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Types;

namespace Org.Webelopers.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;
        private readonly IAuthTokenService _authTokenService;

        public AuthController(
            ILogger<AuthController> logger,
            IAuthService authService,
            IAuthTokenService authTokenService
            )
        {
            _logger = logger;
            _authService = authService;
            _authTokenService = authTokenService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Login([FromBody] LoginDto login)
        {
            _logger.LogInformation($"[{DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}] Logging in {login.Email} ");
            var user = _authService.Authenticate(login.Email, login.Password);
            if (user == null)
            {
                _logger.LogInformation($"Authentication for email '{login.Email}' failed!");
                return NotFound(new { message = "Invalid credentials!" });
            }
            _logger.LogInformation($"[{DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}] Logged in {user.Username} ");
            string token = _authTokenService.GenerateAuthToken(user);
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Register([FromBody] RegisterDto register)
        {
            string passwordHash = 
                (register.Password);
            var user = _authService.Register(register.UserType, register.Username, passwordHash, register.Email, register.FirstName, register.LastName);

            if (user == null)
            {
                _logger.LogInformation($"Register for {register.Username} failed!");
                return Conflict($"User '{register.Username}' already exists.");
            }
            _logger.LogInformation($"Registered {register.Username} ");

            return Ok();
        }
    }
}

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
            var user = _authService.Authenticate(login.Username, login.Password);
            if (user == null)
            {
                _logger.LogInformation($"Authentication for {login.Username} failed!");
                return NotFound(new { message = "Invalid credentials!" });
            }
            _logger.LogInformation($"Logged in {login.Username} ");
            string token = _authTokenService.GenerateAuthToken(user);
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Register([FromBody] RegisterDto register)
        {
            string emailHash = BCrypt.Net.BCrypt.HashPassword(register.Email);
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(register.Password);
            var user = _authService.Register(register.UserType, register.Username, passwordHash, emailHash, register.FirstName, register.LastName);

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

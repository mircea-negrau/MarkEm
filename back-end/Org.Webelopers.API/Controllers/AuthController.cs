using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Authentication;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Types;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Org.Webelopers.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;

        public AuthController(
            IConfiguration configuration,
            ILogger<AuthController> logger,
            IAuthService authService)
        {
            _configuration = configuration;
            _logger = logger;
            _authService = authService;
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
            string token = Generate(user);
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Register([FromBody] RegisterDto register)
        {
            var EmailHash = BCrypt.Net.BCrypt.HashPassword(register.Email);
            var PasswordHash = BCrypt.Net.BCrypt.HashPassword(register.Password);
            var user = _authService.Register(register.UserType, register.Username, PasswordHash,
                EmailHash, register.FirstName, register.LastName);

            if (user == null)
            {
                _logger.LogInformation($"Register for {register.Username} failed!");
                return StatusCode(409, $"User '{register.Username}' already exists.");
            }
            _logger.LogInformation($"Registered {register.Username} ");

            return Ok();
        }

        private string Generate(UserContext user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtConfig:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Username)
            };

            var token = new JwtSecurityToken(_configuration["JwtConfig:Issuer"],
                _configuration["JwtConfig:Audience"],
                claims,
                expires: DateTime.Now.AddHours(14),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

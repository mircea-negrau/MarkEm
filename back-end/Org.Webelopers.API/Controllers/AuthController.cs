using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Contracts.Auth;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Dto;
using System;

public static class MimeTypes
{
    public const string Csv = "text/csv";
    public const string Json = "application/json";
}

namespace Org.Webelopers.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    [Produces(MimeTypes.Json)]
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "<Pending>")]
        private readonly DatabaseContext _context;
        private readonly IStudentAuthService _studentAuthService;
        private readonly JwtService _jwtService;

        public AuthController(
            ILogger<AuthController> logger,
            DatabaseContext context,
            JwtService jwtService,
            IStudentAuthService studentAuthService)
        {
            _logger = logger;
            _context = context;
            _jwtService = jwtService;
            _studentAuthService = studentAuthService;
            _logger.LogInformation("OKAY");
        }

        [HttpPost("register/student")]
        public IActionResult RegisterStudent(RegisterDto dto)
        {
            var student = new Student
            {
                Username = dto.Username,
                EmailHash = BCrypt.Net.BCrypt.HashPassword(dto.Email),
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
            return Created("Success", _studentAuthService.Register(student));
        }

        [HttpGet("login/student")]
        public IActionResult LoginStudent(LoginDto dto)
        {
            var student = _studentAuthService.GetStudentByUsername(dto.Username);
            if (student == null)
            {
                return BadRequest(new { message = "Invalid credentials!" });
            }
            if (!BCrypt.Net.BCrypt.Verify(dto.Password, student.PasswordHash))
            {
                return BadRequest(new { message = "Invalid credentials!" });
            }

            var jwt = _jwtService.Generate(student.Id);
            Response.Cookies.Append("jwt", jwt, new CookieOptions { HttpOnly = true });
            return Ok(new
            {
                message = "Success"
            });
        }

        [HttpGet("student")]
        public IActionResult GetStudent()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);

                Guid studentId = Guid.Parse(token.Issuer);
                var student = _studentAuthService.GetStudentById(studentId);

                return Ok(student);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        [HttpPost("logout/student")]
        public IActionResult LogoutStudent()
        {
            Response.Cookies.Delete("jwt");

            return Ok(new
            {
                message = "Success"
            });
        }
    }
}

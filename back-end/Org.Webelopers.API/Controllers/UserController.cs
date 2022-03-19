using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("teachers")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly DatabaseContext _context;

        public UsersController(ILogger<UsersController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
            _logger.LogInformation("OKAY");
        }

        [HttpGet]
        public IEnumerable<Teacher> Get() => _context.Teachers;
    }
}

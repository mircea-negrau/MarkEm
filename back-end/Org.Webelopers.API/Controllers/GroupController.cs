using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.Persistence.Groups;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Controllers
{
    [ApiController]
    [Route("group")]
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        public GroupController(
            IGroupService groupService
            )
        {
            _groupService = groupService;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GroupDto>))]
        public IActionResult GetGroups()
        {
            return Ok(_groupService.GetAllGroups());
        }

    }
}

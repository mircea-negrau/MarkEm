using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.Groups;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class GroupService : IGroupService
    {
        private readonly DatabaseContext _context;

        public GroupService(DatabaseContext context)
        {
            _context = context;
        }

        public List<GroupDto> GetAllGroups()
        {
            return _context.Groups.Select(group => new GroupDto()
            {
                GroupId = group.Id,
                Number = group.Number
            }).ToList();
        }

    }
}

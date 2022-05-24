using Org.Webelopers.Api.Models.Persistence.Groups;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IGroupService
    {
        public List<GroupDto> GetAllGroups();
    }
}
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.Profiles;
using System;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class ProfileService : IProfileService
    {
        private readonly DatabaseContext _context;

        public ProfileService(DatabaseContext context)
        {
            _context = context;
        }

        public PublicProfileResponseDto GetPublicProfileByUsername(string username)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Username == username);
            return account != null
                ? new PublicProfileResponseDto(account)
                : throw new Exception($"Account with username '{username}' does not exist!");
        }
    }
}

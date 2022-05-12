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

        public ProfileResponseDto GetProfileByUsername(string username)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Username == username);
            return account != null
                ? new ProfileResponseDto(account)
                : throw new Exception($"Account with username '{username}' does not exist!");
        }

        public byte[] GetProfilePictureById(Guid userId)
        {
            return _context.Accounts.FirstOrDefault(x => x.Id == userId).Picture;
        }

        public void SaveProfilePicture(Guid userId, byte[] pictureData)
        {
            _context.Accounts.FirstOrDefault(x => x.Id == userId).Picture = pictureData;
            _context.SaveChanges();
        }
    }
}

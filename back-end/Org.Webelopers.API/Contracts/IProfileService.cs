using Org.Webelopers.Api.Models.Persistence.Profiles;
using System;

namespace Org.Webelopers.Api.Contracts
{
    public interface IProfileService
    {
        public void SaveProfilePicture(Guid userId, byte[] pictureData);

        public byte[] GetProfilePictureById(Guid userId);

        public ProfileResponseDto GetProfileByUsername(string username);

        public void UpdatePassword(Guid userId, string passwordHash);
        public void UpdateAbout(Guid userId, string about);
    }
}

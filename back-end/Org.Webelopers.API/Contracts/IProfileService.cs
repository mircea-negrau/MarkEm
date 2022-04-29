using Org.Webelopers.Api.Models.Persistence.Profiles;

namespace Org.Webelopers.Api.Contracts
{
    public interface IProfileService
    {
        public PublicProfile GetPublicProfileByUsername(string username);
    }
}

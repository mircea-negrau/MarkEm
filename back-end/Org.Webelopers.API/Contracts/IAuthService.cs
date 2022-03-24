using Org.Webelopers.Api.Models.Authentication;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthService
    {
        UserContext Authenticate(string username, string password);
    }
}

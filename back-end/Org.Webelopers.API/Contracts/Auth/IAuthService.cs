using Org.Webelopers.Api.Models.Authentication;

namespace Org.Webelopers.Api.Contracts.Auth
{
    public interface IAuthService
    {
        UserContext Authenticate(string username, string password);
    }
}

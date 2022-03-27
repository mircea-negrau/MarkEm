using Org.Webelopers.Api.Models.Authentication;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthService
    {
        UserContext Authenticate(string username, string password);
        UserContext Register(string userType, string username, string password, string email, string firstName, string lastName);
    }
}

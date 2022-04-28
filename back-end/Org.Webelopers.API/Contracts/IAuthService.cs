using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthService
    {
        Account Authenticate(string username, string password);
        Account Register(string userType, string username, string password, string email, string firstName, string lastName);
    }
}

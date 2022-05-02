using Org.Webelopers.Api.Models.DbEntities;
using System.IdentityModel.Tokens.Jwt;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthTokenService
    {
        public string GenerateAuthToken(Account user);

        public JwtSecurityToken ParseAuthToken(string jwtToken);
    }
}

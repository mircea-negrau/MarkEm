using System;
using Org.Webelopers.Api.Models.DbEntities;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Primitives;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthTokenService
    {
        public string GenerateAuthToken(Account user);

        public JwtSecurityToken ParseAuthToken(string jwtToken);

        public Guid GetAccountId(StringValues authorization);

        public class UidClaimNotFound : Exception
        {
            public UidClaimNotFound() : base("UID claim not found")
            {
            }
        }
    }
}

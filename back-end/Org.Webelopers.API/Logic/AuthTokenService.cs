using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Types;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Org.Webelopers.Api.Logic
{
    public class AuthTokenService : IAuthTokenService
    {
        private readonly IConfiguration _configuration;

        public AuthTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateAuthToken(Account user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtConfig:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(CustomClaimTypes.UserId, user.Id.ToString()),
                new Claim(CustomClaimTypes.Role, user.Role),
                new Claim(CustomClaimTypes.Username, user.Username),
                new Claim(CustomClaimTypes.FirstName, user.FirstName),
                new Claim(CustomClaimTypes.LastName, user.LastName),
            };

            var token = new JwtSecurityToken(_configuration["JwtConfig:Issuer"],
                _configuration["JwtConfig:Audience"],
                claims,
                expires: DateTime.Now.AddHours(14),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public JwtSecurityToken ValidateAuthToken(string jwtToken)
        {
            if (jwtToken.Contains("Bearer"))
            {
                jwtToken = jwtToken.Split("Bearer ")[1];
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            string secureKey = _configuration["JwtConfig:Secret"];
            byte[] key = Encoding.ASCII.GetBytes(secureKey);
            tokenHandler.ValidateToken(jwtToken, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false
            }, out SecurityToken validatedToken);
            return (JwtSecurityToken)validatedToken;
        }
    }
}

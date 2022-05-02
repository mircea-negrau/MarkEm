using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Org.Webelopers.Api.Logic.Requirements
{
    public class ChiefOfDepartmentRequirement : IAuthorizationRequirement
    {
        private DatabaseContext _dbContext;
        private IHttpContextAccessor _contextAccessor;
        private IAuthTokenService _authTokenService;

        public async Task<bool> Pass(IAuthTokenService authTokenService, DatabaseContext dbContext, IHttpContextAccessor contextAccessor)
        {
            _dbContext = dbContext;
            _contextAccessor = contextAccessor;
            _authTokenService = authTokenService;

            try
            {
                var authorization = _contextAccessor.HttpContext.Request.Headers["Authorization"];
                var token = _authTokenService.ParseAuthToken(authorization);
                Guid userId = Guid.Parse(token.Claims.FirstOrDefault(x => x.Type == "uid")?.Value);
                var faculty = _dbContext.Faculties.FirstOrDefault(x => x.ChiefOfDepartmentId == userId);
                return faculty != null ? await Task.FromResult(true) : await Task.FromResult(false);
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Logic.Requirements;
using System.Threading.Tasks;

namespace Org.Webelopers.Api.Logic.Handlers
{
    public class ChiefOfDepartmentAuthorizationHandler : AuthorizationHandler<ChiefOfDepartmentRequirement>
    {
        private readonly DatabaseContext _dbContext;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IAuthTokenService _authTokenService;

        public ChiefOfDepartmentAuthorizationHandler(IAuthTokenService authTokenService, DatabaseContext dbContext, IHttpContextAccessor contextAccessor)
        {
            _dbContext = dbContext;
            _contextAccessor = contextAccessor;
            _authTokenService = authTokenService;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, ChiefOfDepartmentRequirement requirement)
        {
            if (await requirement.Pass(_authTokenService, _dbContext, _contextAccessor))
            {
                context.Succeed(requirement);
            }
        }
    }
}

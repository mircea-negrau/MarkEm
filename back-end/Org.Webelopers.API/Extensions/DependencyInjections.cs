using Microsoft.Extensions.DependencyInjection;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Logic.Auth;
using Org.Webelopers.Api.Logic;

namespace Org.Webelopers.Api.Extensions
{
    public static class DependencyInjections
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IGradesService, GradesService>();
            services.AddScoped<ICurriculumService, CurriculumService>();
            services.AddScoped<IContractService, ContractService>();
        }
    }
}

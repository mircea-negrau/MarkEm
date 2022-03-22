using Microsoft.Extensions.DependencyInjection;
using Org.Webelopers.Api.Contracts.Auth;
using Org.Webelopers.Api.Logic.Auth;

namespace Org.Webelopers.Api.Extensions
{
    public static class DependencyInjections
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}

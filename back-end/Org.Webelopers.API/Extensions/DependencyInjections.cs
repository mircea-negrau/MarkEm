using Microsoft.Extensions.DependencyInjection;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Logic.Auth;
using Org.Webelopers.Api.Logic;
using Microsoft.AspNetCore.Authorization;
using Org.Webelopers.Api.Logic.Handlers;

namespace Org.Webelopers.Api.Extensions
{
    public static class DependencyInjections
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthorizationHandler, ChiefOfDepartmentAuthorizationHandler>();

            services.AddScoped<IGradesService, GradesService>();
            services.AddScoped<ICurriculumService, CurriculumService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IOptionalCourseService, OptionalCourseService>();
            services.AddScoped<IAuthTokenService, AuthTokenService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IStatisticsService, StatisticsService>();
        }
    }
}

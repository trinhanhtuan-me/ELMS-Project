using Microsoft.AspNetCore.Authorization;
using Web.CustomAuthorization;

namespace WebMVC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebMvcServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, EndPointAccessHandler>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("EndpointAccess", policy =>
                {
                    policy.AddRequirements(new EndPointAccessRequirement());
                });
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Auth/Login";
                options.AccessDeniedPath = "/Error/403";
            });

            return services;
        }


    }
}

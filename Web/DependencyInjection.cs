using Microsoft.AspNetCore.Authentication.Cookies;
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Identity/Login";
                    options.AccessDeniedPath = "/Error/403";
                });

            return services;
        }


    }
}

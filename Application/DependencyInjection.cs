using System.Reflection;
using Application.Common.Cache;
using Application.UseCases;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //Add service scoped here
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IFunctionService, FunctionService>();
            services.AddScoped<IParentLinkService, ParentLinkService>();
            services.AddScoped<IPasskeyService, PasskeyService>();
            return services;
        }
    }
}

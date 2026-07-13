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
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IParentLinkService, ParentLinkService>();
            services.AddScoped<IPasskeyService, PasskeyService>();
            services.AddScoped<IManagerDashboardService , ManagerDashboardService>();
            services.AddScoped<IManagerCourseService, ManagerCourseService>();
            services.AddScoped<IManagerCategoryService, ManagerCategoryService>();
            services.AddScoped<IManagerProfileService, ManagerProfileService>();
            services.AddScoped<IManagerFlashcardService, ManagerFlashcardService>();
            services.AddScoped<IManagerRevenueService, ManagerRevenueService>();

            return services;
        }
    }
}

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
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IDiscussionService, DiscussionService>();
            services.AddScoped<ILessonQuestionService, LessonQuestionService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IParentLinkService, ParentLinkService>();
            services.AddScoped<IPasskeyService, PasskeyService>();
            services.AddScoped<IManagerDashboardService, ManagerDashboardService>();
            services.AddScoped<IManagerCourseService, ManagerCourseService>();
            services.AddScoped<IManagerCategoryService, ManagerCategoryService>();
            services.AddScoped<IManagerProfileService, ManagerProfileService>();
            services.AddScoped<IManagerFlashcardService, ManagerFlashcardService>();
            services.AddScoped<IManagerRevenueService, ManagerRevenueService>();
            services.AddScoped<IStudentFamilyService, StudentFamilyService>();
            services.AddScoped<ICourseRequestService, CourseRequestService>();
            services.AddScoped<ICourseReviewService, CourseReviewService>();
            services.AddScoped<ILearningService, LearningService>();
            services.AddScoped<IStudentProfileService, StudentProfileService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<ICourseApprovalService, CourseApprovalService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IParentProgressService, ParentProgressService>();
            services.AddScoped<IParentProfileService, ParentProfileService>();
            services.AddScoped<IStudentProgressService, StudentProgressService>();
            services.AddScoped<ICatalogService, CatalogService>();
            return services;
        }
    }
}

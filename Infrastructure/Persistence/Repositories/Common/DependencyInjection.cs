using Application.Common.Interfaces;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure.Persistence.Repositories.Common
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ElmsDbContext>(options
               => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddKeyedScoped<IFunctionRepository, FunctionRepository>("original");
            services.AddScoped<IFunctionRepository, CacheFunctionRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IMailRepository, MailRepository>();
            services.AddScoped<IOtpRepository, OtpRepository>();
            return services;
        }
    }
}

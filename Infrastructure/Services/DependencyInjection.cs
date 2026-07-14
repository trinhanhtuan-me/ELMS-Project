using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;

namespace Infrastructure.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPhotoService(this IServiceCollection services)
        {
            services.AddScoped<IPhotoService, PhotoService>();
            return services;
        }
    }
}

using Application.Common.Cache;
using Fido2NetLib;
using Infrastructure.Data;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.Repositories.Common;
using Infrastructure.Shared.Cache;
using Infrastructure.Shared.Mails;
using Infrastructure.Shared.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ZiggyCreatures.Caching.Fusion;
using ZiggyCreatures.Caching.Fusion.Serialization.SystemTextJson;
using Application.Interfaces;
namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddRepositories(configuration);
            services.AddCacheService(configuration);
            services.AddMailService(configuration);
            services.AddScoped<IFileStorageService, CloudinaryStorageService>();

            services.AddScoped<Application.Interfaces.IVNPayService, Infrastructure.Shared.Payment.VNPayService>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddFido2Security(configuration);

            return services;
        }

        private static IServiceCollection AddCacheService(this IServiceCollection services, IConfiguration configuration)
        {
            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
            };

            //Configure FusionCache to use Memory Cache (L1 Cache) only
            services.AddFusionCache().WithDefaultEntryOptions(new FusionCacheEntryOptions
            {
                Duration = TimeSpan.FromMinutes(5)
            })
            .WithSerializer(new FusionCacheSystemTextJsonSerializer(jsonOptions));

            return services;
        }

        private static IServiceCollection AddFido2Security(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Fido2Configuration>(configuration.GetSection("Fido2"));

            services.AddSingleton<IFido2>(sp =>
            {
                var fidoConfig = sp.GetRequiredService<IOptions<Fido2Configuration>>().Value;
                return new Fido2(fidoConfig);
            });

            return services;
        }
    }
}

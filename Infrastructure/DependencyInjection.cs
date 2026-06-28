using Infrastructure.Data;
using Infrastructure.Persistence.Repositories.Common;
using Infrastructure.Shared.Mails;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZiggyCreatures.Caching.Fusion;
using ZiggyCreatures.Caching.Fusion.Serialization.SystemTextJson;
namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddRepositories(configuration);
            services.AddCacheService(configuration);
            services.AddMailService(configuration);
            return services;
        }

        private static IServiceCollection AddCacheService(this IServiceCollection services, IConfiguration configuration)
        {
            //Configure Redis using L2 Cache
            var redisConnection = configuration.GetConnectionString("Redis");
            services.AddStackExchangeRedisCache(option =>
            {
                option.Configuration =  redisConnection;
                option.InstanceName = "ELMS_";
            });

            //Configure FusionCache consider Redis as L2 Cache
            services.AddFusionCache().WithDefaultEntryOptions(new FusionCacheEntryOptions
            {
                Duration = TimeSpan.FromMinutes(5)
            })
            .WithSerializer(new FusionCacheSystemTextJsonSerializer())
            .WithRegisteredDistributedCache();

            return services;
        }
    }
}

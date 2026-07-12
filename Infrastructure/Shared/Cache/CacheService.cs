using Application.Common.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiggyCreatures.Caching.Fusion;

namespace Infrastructure.Shared.Cache
{
    public class CacheService(IFusionCache _cache) : ICacheService
    {
        public async Task<T?> GetAsync<T>(string key)
        {
            return await _cache.GetOrDefaultAsync<T>(key);
        }

        public async Task RemoveAsync(string key)
        {
            await _cache.RemoveAsync(key);
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan expiration)
        {
            await _cache.SetAsync(key, value, expiration);
        }
    }
}

using Application.Common.Mails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiggyCreatures.Caching.Fusion;

namespace Infrastructure.Shared.Mails
{
    public class MailBodyBuilder(IFusionCache _cache) : IMailBodyBuilder
    {
        public async Task<string> BuildOtpRegistrationEmail(string userName, string otpCode)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Shared", "Mails", "Templates", "OtpRegistration.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "RegistrationTemplate",
                factory: async (ctx, _) =>
                {
                    if (!File.Exists(templatePath))
                    {
                        throw new FileNotFoundException($"Không tìm thấy file tại {templatePath}");
                    }
                    return await File.ReadAllTextAsync(templatePath);
                },
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
                );

            var finalHtml = templateContent!
                    .Replace("{{Username}}", userName)
                    .Replace("{{OtpCode}}", otpCode);

            return finalHtml;
        }

    }
}

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

        public async Task<string> BuildOtpForgotPassword(string userName, string otpCode)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Shared", "Mails", "Templates", "ForgotPassword.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "ForgotPasswordTemplate",
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
        public async Task<string> BuildPaymentSuccessParentEmail(string parentName, Guid orderId, string itemsHtml, decimal totalAmount, string txnRef, DateTime capturedAt)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shared", "Mails", "Templates", "PaymentSuccessParent.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "PaymentSuccessParentTemplate",
                factory: async (ctx, _) => await File.ReadAllTextAsync(templatePath),
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
            );

            return templateContent!
                .Replace("{{ParentName}}", parentName)
                .Replace("{{OrderId}}", orderId.ToString())
                .Replace("{{ItemsHtml}}", itemsHtml)
                .Replace("{{TotalAmount}}", totalAmount.ToString("N0"))
                .Replace("{{TxnRef}}", txnRef)
                .Replace("{{CapturedAt}}", capturedAt.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public async Task<string> BuildCourseActivationStudentEmail(string studentName, string courseTitle, string courseUrl)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shared", "Mails", "Templates", "CourseActivationStudent.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "CourseActivationStudentTemplate",
                factory: async (ctx, _) => await File.ReadAllTextAsync(templatePath),
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
            );

            return templateContent!
                .Replace("{{StudentName}}", studentName)
                .Replace("{{CourseTitle}}", courseTitle)
                .Replace("{{CourseUrl}}", courseUrl);
        }

        public async Task<string> BuildParentLink(string parentName, string studentName)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               "Shared", "Mails", "Templates", "ParentLinkRequest.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "ParentLinkRequestTemplate",
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
                    .Replace("{{ParentName}}", parentName)
                    .Replace("{{StudentName}}", studentName);

            return finalHtml;
        }

        public async Task<string> BuildParentLinkApproved(string studentName, string parentName)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               "Shared", "Mails", "Templates", "ParentLinkApproved.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "ParentLinkApprovedTemplate",
                factory: async (ctx, _) => await File.ReadAllTextAsync(templatePath),
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
            );

            return templateContent!
                .Replace("{{StudentName}}", studentName)
                .Replace("{{ParentName}}", parentName)
                .Replace("{{Date}}", DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public async Task<string> BuildParentLinkRejected(string studentName, string parentName, string note)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               "Shared", "Mails", "Templates", "ParentLinkRejected.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "ParentLinkRejectedTemplate",
                factory: async (ctx, _) => await File.ReadAllTextAsync(templatePath),
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
            );

            return templateContent!
                .Replace("{{StudentName}}", studentName)
                .Replace("{{ParentName}}", parentName)
                .Replace("{{Note}}", string.IsNullOrEmpty(note) ? "Không có lý do cụ thể." : note)
                .Replace("{{Date}}", DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public async Task<string> BuildParentLinkUnlinked(string studentName, string parentName, string note)
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               "Shared", "Mails", "Templates", "ParentLinkUnlinked.html");

            var templateContent = await _cache.GetOrSetAsync<string>(
                key: "ParentLinkUnlinkedTemplate",
                factory: async (ctx, _) => await File.ReadAllTextAsync(templatePath),
                options: new FusionCacheEntryOptions().SetSkipDistributedCache(true, true)
            );

            return templateContent!
                .Replace("{{StudentName}}", studentName)
                .Replace("{{ParentName}}", parentName)
                .Replace("{{Note}}", string.IsNullOrEmpty(note) ? "Không có lý do cụ thể." : note)
                .Replace("{{Date}}", DateTime.UtcNow.AddHours(7).ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}

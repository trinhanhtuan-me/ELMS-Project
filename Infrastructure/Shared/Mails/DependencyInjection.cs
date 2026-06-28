using Application.Common.Mails;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.Mails
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMailService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MailOptions>(configuration.GetSection("Mail"));
            services.AddScoped<IMailBodyBuilder, MailBodyBuilder>();
            services.AddScoped<IMailClient, MailClient>();
            services.AddHostedService<MailProcessor>();
            return services;
        }
    }


}

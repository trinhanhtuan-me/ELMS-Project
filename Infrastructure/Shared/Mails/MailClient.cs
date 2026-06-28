using Application.Common.Mails;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace Infrastructure.Shared.Mails
{
    public class MailClient : IMailClient
    {
        private readonly MailOptions _options;
        public MailClient(IOptions<MailOptions> options)
        {
            _options = options.Value;
        }
        public async Task SendAsync(string to, string subject, string body)
        {
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(_options.SenderEmail));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;

            var builder = new BodyBuilder { HtmlBody = body };
            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_options.Host, _options.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_options.Username, _options.Password);

            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }


    }
}


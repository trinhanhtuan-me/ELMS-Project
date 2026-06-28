using Application.Common.Mails;
using Application.Interfaces;
using Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Polly;


namespace Infrastructure.Shared.Mails
{
    public class MailProcessor : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<MailProcessor> _logger;
        private readonly SemaphoreSlim _semaphore = new(50);

        public MailProcessor(IServiceProvider serviceProvider, ILogger<MailProcessor> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Mail Procesor start ...");
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await ProcessPedingEmailAsync(stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "MailProcessor error | {errorMessage}| ", ex.Message);
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }

        }

        private async Task ProcessPedingEmailAsync(CancellationToken stoppingToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var mailRepository = scope.ServiceProvider.GetRequiredService<IMailRepository>();
            var mailClient = scope.ServiceProvider.GetRequiredService<IMailClient>();

            var pendingMails = await mailRepository.FindPendingEmailAsync();
            if (!pendingMails.Any()) return;
            _logger.LogInformation("System is sending email ...");

            //Polly for retrying
            var retryPolicy = Policy
                .Handle<Exception>()
                .WaitAndRetry(3,
                retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                (exception, timeSpan, retryCount, context) =>
                {
                    _logger.LogWarning($"Network errror. Retry count: {retryCount} ... Error: {exception.Message}");
                });

            var tasks = pendingMails.Select(async mail =>
            {
                await _semaphore.WaitAsync(stoppingToken);
                try
                {
                    await retryPolicy.Execute(async () =>
                    {
                        await mailClient.SendAsync(mail.To, mail.Subject, mail.Body);
                    });
                    await mailRepository.UpdateMailStatusAsync(mail, MailStatus.Sent, null);
                    _logger.LogInformation($"Successful to: {mail.To}");
                }
                catch (Exception ex)
                {
                    await mailRepository.UpdateMailStatusAsync(mail, MailStatus.Failed, ex.Message);
                    _logger.LogError($"Fail to: {mail.To}");
                }
                finally
                {
                    _semaphore.Release();
                }
            });

            await Task.WhenAll(tasks);
        }
    }
}

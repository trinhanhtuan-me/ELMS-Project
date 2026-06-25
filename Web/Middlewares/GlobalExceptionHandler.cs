using Microsoft.AspNetCore.Diagnostics;

namespace WebMVC.MIddlewares
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(
                exception,
                "Unhandled exception occurred | Path: {Path} | Message: {ErrorMessage}",
                httpContext.Request.Path,
                exception.Message
                );

            httpContext.Response.Redirect("/Error/500");
            return true;
        }
    }
}

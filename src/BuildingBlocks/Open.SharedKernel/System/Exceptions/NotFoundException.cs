using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Open.SharedKernel.System.Exceptions;

public class NotFoundException(string? code, string? message) : BusinessException(code, message)
{
    
}

public sealed class NotFoundExceptionHandler(ILogger<NotFoundExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, 
        Exception exception, 
        CancellationToken cancellationToken)
    {
        if (exception is not NotFoundException notFoundException)
        {
            return false;
        }
        
        logger.LogWarning(
            exception,
            "[{Handler}] Not found exception occurred: {Message}",
            nameof(NotFoundExceptionHandler),
            notFoundException.Message
        );
        
        await TypedResults
            .NotFound(Result.NotFound(notFoundException.Message))
            .ExecuteAsync(httpContext);

        return true;
    }
}

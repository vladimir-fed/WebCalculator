using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

namespace WebCalculator.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void OnException(ExceptionContext context)
        {
            var response = new
            {
                Message = context.Exception.Message,
                StackTrace = context.Exception.StackTrace
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = 500,
                DeclaredType = response.GetType()
            };

            _logger.LogError("Application error: ", context.Exception);
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace WebCalculator.Filters
{
    public class ValidatorActionFilter : IActionFilter
    {
        private readonly ILogger<ValidatorActionFilter> _logger;

        public ValidatorActionFilter(ILogger<ValidatorActionFilter> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
                _logger.LogWarning("Model is not valid.");
                filterContext.Result = new BadRequestObjectResult(filterContext.ModelState);
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}

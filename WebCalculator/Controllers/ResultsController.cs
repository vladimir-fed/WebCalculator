using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WebCalculator.Models;
using WebCalculator.Services;

namespace WebCalculator.Controllers
{
    [Route("api/[controller]")]
    public class ResultsController : Controller
    {
        private readonly IResultsService _operationService;
        private readonly ILogger<ResultsController> _logger;

        public ResultsController(IResultsService operationService, ILogger<ResultsController> logger)
        {
            _operationService = operationService ?? throw new ArgumentNullException(nameof(operationService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation("Getting result {ID}", id);
            var result =_operationService.GetResultById(id);
            if (result == null)
            {
                _logger.LogWarning("GetById({ID}) Not Found.", id);
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting list of results.");
            return Ok(_operationService.GetResults());
        }

        [HttpPost]
        public IActionResult Post([FromBody] OperationModel operationModel)
        {
            _logger.LogInformation("Creating result.");
            return Ok(_operationService.ExecuteOperation(operationModel));
        }
    }
}

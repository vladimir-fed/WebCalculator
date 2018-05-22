using System;
using System.Collections.Generic;
using WebCalculator.Models;
using WebCalculator.Repositories;
using WebCalculator.Services.Operations.Factories;

namespace WebCalculator.Services
{
    public class ResultsService : IResultsService
    {
        private readonly IResultRepository _resultRepository;
        private readonly IOperationFactory _operationFactory;

        public ResultsService(IResultRepository resultRepository, IOperationFactory operationFactory)
        {
            _resultRepository = resultRepository ?? throw new ArgumentNullException(nameof(resultRepository));
            _operationFactory = operationFactory ?? throw new ArgumentNullException(nameof(operationFactory));
        }

        public int ExecuteOperation(OperationModel requestModel)
        {
            var operation = _operationFactory.GetOperation(requestModel.Operation);

            var resultModel = new ResultModel
            {
                Result = operation.Exec(requestModel)
            };
            _resultRepository.Create(resultModel);

            return resultModel.Id;
        }

        public ResultModel GetResultById(int id)
        {
            return _resultRepository.GetById(id);
        }

        public IEnumerable<ResultModel> GetResults()
        {
            return _resultRepository.GetAll();
        }
    }
}

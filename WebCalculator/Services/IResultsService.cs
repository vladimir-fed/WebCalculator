using System.Collections.Generic;
using WebCalculator.Models;

namespace WebCalculator.Services
{
    public interface IResultsService
    {
        int ExecuteOperation(OperationModel requestModel);
        ResultModel GetResultById(int id);
        IEnumerable<ResultModel> GetResults();
    }
}

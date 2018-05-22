using WebCalculator.Models;

namespace WebCalculator.Services.Operations
{
    public interface IOperation
    {
        double Exec(OperationModel requestModel);
    }
}

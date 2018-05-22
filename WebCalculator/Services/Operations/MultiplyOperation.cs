using WebCalculator.Models;

namespace WebCalculator.Services.Operations
{
    public class MultiplyOperation : IOperation
    {
        public double Exec(OperationModel operationModel)
        {
            return operationModel.FirstOperand * operationModel.SecondOperand;
        }
    }
}
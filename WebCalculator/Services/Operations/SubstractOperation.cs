using WebCalculator.Models;

namespace WebCalculator.Services.Operations
{
    public class SubstractOperation : IOperation
    {
        public double Exec(OperationModel operationModel)
        {
            return operationModel.FirstOperand - operationModel.SecondOperand;
        }
    }
}

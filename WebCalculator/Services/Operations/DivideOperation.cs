using WebCalculator.Models;

namespace WebCalculator.Services.Operations
{
    public class DivideOperation : IOperation
    {
        public double Exec(OperationModel operationModel)
        {
            return operationModel.FirstOperand / operationModel.SecondOperand;
        }
    }
}

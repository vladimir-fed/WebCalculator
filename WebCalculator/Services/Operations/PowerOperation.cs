using System;
using WebCalculator.Models;

namespace WebCalculator.Services.Operations
{
    public class PowerOperation : IOperation
    {
        public double Exec(OperationModel operationModel)
        {
            return Math.Pow(operationModel.FirstOperand, operationModel.SecondOperand);
        }
    }
}

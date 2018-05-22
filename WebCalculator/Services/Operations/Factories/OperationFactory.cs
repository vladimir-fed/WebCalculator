using System;

namespace WebCalculator.Services.Operations.Factories
{
    public class OperationFactory : IOperationFactory
    {
        public IOperation GetOperation(OperationType operationEnum)
        {
            switch (operationEnum)
            {
                case OperationType.Add:
                    return new AddOperation();
                case OperationType.Substract:
                    return new SubstractOperation();
                case OperationType.Multiply:
                    return new MultiplyOperation();
                case OperationType.Divide:
                    return new DivideOperation();
                case OperationType.Power:
                    return new PowerOperation();
                default:
                    throw new NotSupportedException($"{nameof(operationEnum)} '{operationEnum}' is not supported");
            }
        }
    }
}

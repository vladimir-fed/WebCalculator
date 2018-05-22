namespace WebCalculator.Services.Operations.Factories
{
    public interface IOperationFactory
    {
        IOperation GetOperation(OperationType operationEnum);
    }
}
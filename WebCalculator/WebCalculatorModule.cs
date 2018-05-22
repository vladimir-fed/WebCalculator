using Autofac;
using WebCalculator.Repositories;
using WebCalculator.Services;
using WebCalculator.Services.Operations.Factories;

namespace WebCalculator
{
    public class WebCalculatorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ResultsService>().As<IResultsService>().SingleInstance();
            builder.RegisterType<ResultStubRepository>().As<IResultRepository>().SingleInstance();
            builder.RegisterType<OperationFactory>().As<IOperationFactory>().SingleInstance();
        }
    }
}

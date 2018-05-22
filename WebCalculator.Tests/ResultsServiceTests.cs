using Autofac.Extras.Moq;
using FluentAssertions;
using Moq;
using WebCalculator.Models;
using WebCalculator.Repositories;
using WebCalculator.Services;
using WebCalculator.Services.Operations.Factories;
using Xunit;

namespace WebCalculator.Tests
{
    public class ResultsServiceTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldCalc(OperationModel operationRequestModel, double result)
        {
            using (var mock = AutoMock.GetLoose())
            {
                double actualValue = 0;
                mock.Mock<IResultRepository>()
                    .Setup(x => x.Create(It.IsAny<ResultModel>()))
                    .Callback<ResultModel>(r => actualValue = r.Result);

                mock.Provide<IOperationFactory>(new OperationFactory());
                var service = mock.Create<ResultsService>();
                service.ExecuteOperation(operationRequestModel);

                actualValue.Should().BeApproximately(result, 1e-10);
            }
        }

        [Fact]
        public void ShouldGetResult()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var expectedValue = new ResultModel
                {
                    Id = 3,
                    Result = 15
                };

                mock.Mock<IResultRepository>()
                    .Setup(x => x.GetById(It.Is<int>(i => i == 3)))
                    .Returns(() => expectedValue);

                var service = mock.Create<ResultsService>();
                var actualValue = service.GetResultById(3);

                actualValue.Should().BeEquivalentTo(expectedValue);
            }
        }
    }
}

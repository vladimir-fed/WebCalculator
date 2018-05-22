using System.Collections;
using System.Collections.Generic;
using WebCalculator.Models;
using WebCalculator.Services;

namespace WebCalculator.Tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new OperationModel
                {
                    FirstOperand = 5,
                    SecondOperand = 2,
                    Operation = OperationType.Add
                },
                7
            },
            new object[] {
                new OperationModel
                {
                    FirstOperand = 5,
                    SecondOperand = 2,
                    Operation = OperationType.Multiply
                },
                10
            }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

using FluentValidation;
using System;
using System.Linq;
using WebCalculator.Models;
using WebCalculator.Services;

namespace WebCalculator.Validators
{
    public class OperationRequestValidator : AbstractValidator<OperationModel>
    {
        public OperationRequestValidator()
        {
            RuleFor(m => m.Operation).IsInEnum()
                .WithMessage($"'Operation' property is invalid. Possible values : {string.Join(",", Enum.GetValues(typeof(OperationType)).Cast<OperationType>())}");
        }
    }
}

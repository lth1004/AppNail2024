using FluentValidation;
using NailApp.API.Models;

namespace NailApp.API.Validators
{
    public class CreateUserRequestValidator : AbstractValidator<User>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.UserName).MaximumLength(100);
            RuleFor(x => x.PassWord).MaximumLength(100);
            RuleFor(x => x.Address).MaximumLength(255);
            RuleFor(x => x.Contract).MaximumLength(100);
        }
    }
}

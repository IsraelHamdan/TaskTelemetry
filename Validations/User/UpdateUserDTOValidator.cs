using FluentValidation;
using TaskTelemetry.DTOs.User;

namespace TaskTelemetry.Validations.User;

public class UpdateUserDTOValidator : AbstractValidator<UpdateUserDTO>
{
  public UpdateUserDTOValidator()
  {
    RuleFor(x => x.Name)
      .MinimumLength(3)
      .MaximumLength(100)
      .When(x => !string.IsNullOrWhiteSpace(x.Name));

    RuleFor(x => x.Email)
      .EmailAddress()
      .When(x => !string.IsNullOrWhiteSpace(x.Email));

    RuleFor(x => x.Password)
      .MinimumLength(8)
      .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$")
      .When(x => !string.IsNullOrWhiteSpace(x.Password));

    RuleFor(x => x.PhoneNumber)
      .MinimumLength(10)
      .MaximumLength(15)
      .When(x => !string.IsNullOrWhiteSpace(x.PhoneNumber));
  }
}

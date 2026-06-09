using FluentValidation;
using TaskTelemetry.DTOs.User;

namespace TaskTelemetry.Validations;

public class CreateUserDTOValidator : AbstractValidator<CreateUserDTO>
{
  public CreateUserDTOValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .MinimumLength(3)
      .MaximumLength(100);

    RuleFor(x => x.Email)
      .NotEmpty()
      .EmailAddress();

    RuleFor(x => x.PhoneNumber)
      .NotEmpty()
      .Matches(@"/^\(\d{2}\)\s?9\d{4}-?\d{4}$/");

    RuleFor(x => x.Password)
      .NotEmpty()
      .MinimumLength(6)
      .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$")
      .WithMessage("Password must contain uppercase, lowercase and number.");
  }
}

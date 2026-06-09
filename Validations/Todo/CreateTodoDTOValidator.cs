using FluentValidation;
using TaskTelemetry.DTOs.Todo;

namespace TaskTelemetry.Validations.Todo;

public class CreateTodoDtoValidator : AbstractValidator<CreateTodoDTO>
{
  public CreateTodoDtoValidator()
  {
    RuleFor(x => x.Title)
      .NotEmpty()
      .MinimumLength(3)
      .MaximumLength(150);

    RuleFor(x => x.Description)
      .MaximumLength(1000);

    RuleFor(x => x.Deadline)
      .GreaterThan(DateTime.UtcNow)
      .WithMessage("Deadline must be in the future.");
  }
}

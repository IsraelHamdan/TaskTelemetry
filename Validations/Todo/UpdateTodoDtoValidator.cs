using FluentValidation;
using TaskTelemetry.DTOs.Todo;

namespace TaskTelemetry.Validations.Todo;

public class UpdateTodoDTOValidator : AbstractValidator<UpdateTodoDTO>
{
  public UpdateTodoDTOValidator()
  {
    RuleFor(x => x.Title)
      .MinimumLength(3)
      .MaximumLength(150)
      .When(x => !string.IsNullOrWhiteSpace(x.Title));

    RuleFor(x => x.Description)
      .MaximumLength(1000)
      .When(x => !string.IsNullOrWhiteSpace(x.Description));

    RuleFor(x => x.Deadline)
      .GreaterThan(DateTimeOffset.UtcNow)
      .When(x => x.Deadline.HasValue);

    RuleFor(x => x.Status)
      .IsInEnum()
      .When(x => x.Status.HasValue);
  }
}

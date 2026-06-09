using TaskTelemetry.Enums;

namespace TaskTelemetry.DTOs.Todo;

public record UpdateTodoDTO(
  string? Title,
  string? Description,
  DateTimeOffset? Deadline,
  TodoStatus? Status
);

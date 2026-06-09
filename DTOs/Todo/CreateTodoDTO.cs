namespace TaskTelemetry.DTOs.Todo;

public record CreateTodoDTO(
  string Title, 
  string Description,
  DateTimeOffset Deadline
);

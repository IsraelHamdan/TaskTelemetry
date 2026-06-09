using TaskTelemetry.Enums;

namespace TaskTelemetry.DTOs.Todo;

public record TodoResponseDTO(
  Guid Id,
  string Title,
  string Description,
  DateTimeOffset Deadline,
  TodoStatus Status,
  DateTime CreatedAt,  
  DateTime UpdatedAt
);

namespace TaskTelemetry.DTOs.User;

public record UpdateUserDTO(
  string? Name,
  string? Email,
  string? Password,
  string? PhoneNumber
);

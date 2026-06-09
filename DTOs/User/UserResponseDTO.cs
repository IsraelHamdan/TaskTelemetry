namespace TaskTelemetry.DTOs.User;

public record UserResponseDTO(
  Guid id,
  string Name,
  string Email,
  string Password,
  string PhoneNumber,
  DateTime CreatedAt,
  DateTime UpdatedAt
);

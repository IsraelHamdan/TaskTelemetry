namespace TaskTelemetry.DTOs.User;

public record CreateUserDTO(
  string Name,
  string Email,
  string Password,
  string PhoneNumber
);

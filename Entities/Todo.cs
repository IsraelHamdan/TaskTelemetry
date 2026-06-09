using TaskTelemetry.Enums;

namespace TaskTelemetry.Entities;

public class Todo
{
  public Guid Id { get; private set; }
  public string Title { get; private set; }
  public string Description { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }
  public DateTimeOffset Deadline { get; private set; }
  public TodoStatus Status { get; private set; }
  public Guid UserId { get; set; }
  public User User { get; private set; }
  
  public Todo()
  {
  }

  public Todo(Guid id, string title, string description, DateTime createdAt, DateTime updatedAt, DateTime deadline, TodoStatus status, Guid userId, User user)
  {
    Id = id;
    Title = title;
    Description = description;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    Deadline = deadline;
    Status = TodoStatus.Pending;
    UserId = userId;
    User = user;
  }
}

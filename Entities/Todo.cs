namespace TaskTelemetry.Entities;

public class Todo
{
  public Guid Id { get; private set; }
  public string Title { get; private set; }
  public string Description { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime UpdatedAt { get; private set; }
  public DateTime Deadline { get; private set; }
  public bool IsCompleted { get; private set; }
  public Guid UserId { get; set; }
  public User User { get; private set; }
  
  public Todo()
  {
  }

  public Todo(Guid id, string title, string description, DateTime createdAt, DateTime updatedAt, DateTime deadline, bool isCompleted)
  {
    Id = id;
    Title = title;
    Description = description;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    Deadline = deadline;
    IsCompleted = isCompleted;
  }
}

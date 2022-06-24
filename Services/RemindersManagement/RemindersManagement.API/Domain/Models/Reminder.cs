namespace RemindersManagement.API.Domain.Models;

public enum ReminderStatus
{
    Doing,
    Finished,
}
public class Reminder
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public ReminderStatus Status { get; set; }
}

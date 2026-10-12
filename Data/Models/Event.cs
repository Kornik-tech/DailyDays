namespace DailyDays.Data.Models;

public class Event
{
    public int Id { get; init; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public DateTime Reminder { get; set; }
    public string RepeatFrequency { get; set; }

    public int CalendarId { get; set; }
    public required Calendar Calendar { get; set; }
}
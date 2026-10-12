using System.ComponentModel.DataAnnotations;

namespace DailyDays.Data.Models;

public class User
{
    public int Id { get; init; }

    [EmailAddress, MaxLength(100)]
    public required string Email { get; init; }

    [MaxLength(100)]
    public required string Password { get; init; }

    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    public ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

}
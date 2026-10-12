using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DailyDays.Data.Models;

public class Calendar
{
    public int Id { get; init; }
    [MaxLength(50)]
    public required string Category { get; set; }
    [MaxLength(6)]
    public string? Color { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }

    public ICollection<Event> Events { get; set; } = new List<Event>();
}
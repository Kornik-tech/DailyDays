using System.ComponentModel.DataAnnotations;

namespace DailyDays.Data.Models;

public class User
{
    public int Id { get; init; }
    [EmailAddress, MaxLength(100)]
    public required string Email { get; set; }
    [MaxLength(100)]
    public required string Password { get; set; }
}
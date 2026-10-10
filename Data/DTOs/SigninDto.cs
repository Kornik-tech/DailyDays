using System.ComponentModel.DataAnnotations;

namespace DailyDays.Data.DTOs;

public class SigninDto
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
    public string? Email { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
    public string? Password { get; set; }
}
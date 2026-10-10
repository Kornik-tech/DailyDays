using System.Security.Claims;
using DailyDays.Data.DTOs;

namespace DailyDays.Services;

public interface IAuthService
{
    Task<(ClaimsPrincipal?, string?)> SignIn(SigninDto model);
}
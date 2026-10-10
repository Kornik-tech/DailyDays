using System.Security.Claims;
using DailyDays.Data.Context;
using DailyDays.Data.DTOs;
using DailyDays.Data.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;

namespace DailyDays.Services;

public class AuthService(AppDbContext context) : IAuthService
{
    public Task<(ClaimsPrincipal?, string?)> SignIn(SigninDto model)
    {
        var user = context.Users.FirstOrDefault(x => x.Email == model.Email);
        if (user is null || user.Password != model.Password)
        {
            return Task.FromResult<(ClaimsPrincipal?, string?)>((null, "Invalid email or password"));
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Email, user.Email)
        };

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);

        return Task.FromResult<(ClaimsPrincipal?, string?)>((principal, null));
    }
}
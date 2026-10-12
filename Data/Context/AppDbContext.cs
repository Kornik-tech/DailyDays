using DailyDays.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyDays.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<Event> Events { get; set; }
}
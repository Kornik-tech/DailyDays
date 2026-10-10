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
}
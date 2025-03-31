using Microsoft.EntityFrameworkCore;
using OnCheck.Shared.Models;

namespace OnCheck.API.Data;

public class OnCheckDbContext : DbContext
{
    public OnCheckDbContext(DbContextOptions<OnCheckDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<TaskItem> Tasks { get; set; }
}

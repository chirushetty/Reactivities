using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }
    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    // {

    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Activity>()
            .Property(a => a.Id)
            .ValueGeneratedOnAdd();
    }
}

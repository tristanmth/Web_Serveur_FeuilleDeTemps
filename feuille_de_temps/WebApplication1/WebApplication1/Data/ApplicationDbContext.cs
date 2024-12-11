using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }

    public DbSet<Sprint> Sprints { get; set; }
    public DbSet<Membre> Membres { get; set; }
    public DbSet<TempsTravail> TempsTravails { get; set; }
}

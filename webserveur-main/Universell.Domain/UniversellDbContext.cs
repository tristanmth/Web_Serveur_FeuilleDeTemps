using Microsoft.EntityFrameworkCore;
using Universell.Domain.Entities;

namespace Universell.Domain
{
    public class UniversellDbContext : DbContext
    {
        public UniversellDbContext(DbContextOptions<UniversellDbContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Temps> Temps { get; set; }
        public DbSet<Connexion> Connexions { get; set; }
        public DbSet<Sprint> Sprints { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurations supplémentaires si nécessaire
        }
    }
}

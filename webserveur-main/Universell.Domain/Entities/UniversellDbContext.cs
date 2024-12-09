using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Universell.Domain.Entities.Configurations;

namespace Universell.Domain.Entities
{
    public class UniversellDbContext : IdentityDbContext<Utilisateur>
    {

        public virtual DbSet<Adresse> Adresses { get; set; }
        public virtual DbSet<Univers> Univers { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<ProduitCategorie> ProduitCategories { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<ProduitCommande> ProduitCommandes { get; set; }
        public virtual DbSet<ContactMessage> ContactMessages { get; set; }



        public UniversellDbContext(DbContextOptions<UniversellDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AdresseConfiguration());
            builder.ApplyConfiguration(new UniversConfiguration());
            builder.ApplyConfiguration(new CategorieConfiguration());
            builder.ApplyConfiguration(new ProduitConfiguration());
            builder.ApplyConfiguration(new ProduitCategorieConfiguration());
            builder.ApplyConfiguration(new CommandeConfiguration());
            builder.ApplyConfiguration(new ProduitCommandeConfiguration());
            builder.ApplyConfiguration(new ContactMessageConfiguration());
        }
    }
}

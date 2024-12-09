using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Universell.Domain.Entities.Configurations
{
    public class ProduitCommandeConfiguration : IEntityTypeConfiguration<ProduitCommande>
    {
        public void Configure(EntityTypeBuilder<ProduitCommande> builder)
        {
            builder.ToTable("ProduitCommande");
            builder.HasKey(pc => pc.Id);
            builder.HasOne(pc => pc.Produit)
                   .WithMany(p => p.ProduitCommandes)
                   .HasForeignKey(pc => pc.ProduitId)
                   .IsRequired();
            builder.HasOne(pc => pc.Commande)
                   .WithMany(c => c.ProduitCommandes)
                   .HasForeignKey(pc => pc.CommandeId)
                   .IsRequired();
            builder.HasIndex(pc => new
            {
                pc.ProduitId,
                pc.CommandeId
            }).IsUnique();
        }
    }
}

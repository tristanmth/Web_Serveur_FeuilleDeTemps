using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Universell.Domain.Entities.Configurations
{
    public class ProduitCategorieConfiguration : IEntityTypeConfiguration<ProduitCategorie>
    {
        public void Configure(EntityTypeBuilder<ProduitCategorie> builder)
        {
            builder.ToTable("ProduitCategorie");
            builder.HasKey(pc => pc.Id);
            builder.HasOne(pc => pc.Produit)
                   .WithMany(p => p.ProduitCategories)
                   .HasForeignKey(pc => pc.ProduitId)
                   .IsRequired();
            builder.HasOne(pc => pc.Categorie)
                   .WithMany(c => c.ProduitCategories)
                   .HasForeignKey(pc => pc.CategorieId)
                   .IsRequired();
            builder.HasIndex(pc => new
            {
                pc.ProduitId,
                pc.CategorieId
            }).IsUnique();
        }
    }

}

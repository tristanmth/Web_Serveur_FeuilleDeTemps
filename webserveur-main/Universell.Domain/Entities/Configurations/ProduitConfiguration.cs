using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Universell.Domain.Entities.Configurations
{
    public class ProduitConfiguration : IEntityTypeConfiguration<Produit>
    {
        public void Configure(EntityTypeBuilder<Produit> builder)
        {
            builder.ToTable("Produit");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nom).IsRequired();
            builder.HasOne(x => x.Univers)
                .WithMany(x => x.Produits)
                .HasForeignKey(x => x.UniversId)
                .IsRequired();
            builder.Property(x => x.Prix).IsRequired();
            builder.Property(x => x.Stock).IsRequired();

        }
    }
}

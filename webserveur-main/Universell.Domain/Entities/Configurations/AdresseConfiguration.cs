using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Universell.Domain.Entities.Configurations
{
    public class AdresseConfiguration : IEntityTypeConfiguration<Adresse>
    {
        public void Configure(EntityTypeBuilder<Adresse> builder)
        {
            builder.ToTable("Adresse");
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Utilisateur)
                   .WithMany(u => u.Adresses)
                   .HasForeignKey(a => a.UtilisateurId)
                   .IsRequired();
            builder.Property(a => a.Nom).IsRequired();
            builder.Property(a => a.CodePostal).IsRequired();
        }
    }

}

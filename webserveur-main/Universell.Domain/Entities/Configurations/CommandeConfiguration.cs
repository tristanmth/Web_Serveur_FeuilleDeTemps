using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Universell.Domain.Entities.Configurations
{
    public class CommandeConfiguration : IEntityTypeConfiguration<Commande>
    {
        public void Configure(EntityTypeBuilder<Commande> builder)
        {
            builder.ToTable("Commande");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Utilisateur)
                   .WithMany(u => u.Commandes)
                   .HasForeignKey(c => c.UtilisateurId)
                   .IsRequired();
            builder.Property(c => c.DateCreation).IsRequired();
            builder.Property(c => c.Etat).IsRequired();
        }
    }

}

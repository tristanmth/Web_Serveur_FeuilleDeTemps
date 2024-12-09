using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universell.Domain.Entities;

namespace Universell.Domain.Entities.Configurations
{
    public class UtilisateurConfiguration : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable("Utilisateurs");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nom).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.HasMany(u => u.Temps)
                   .WithOne()
                   .HasForeignKey(t => t.UtilisateurId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}


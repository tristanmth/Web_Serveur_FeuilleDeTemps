using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universell.Domain.Entities;

namespace Universell.Domain.Entities.Configurations
{
    public class TempsConfiguration : IEntityTypeConfiguration<Temps>
    {
        public void Configure(EntityTypeBuilder<Temps> builder)
        {
            builder.ToTable("Temps");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.Categorie).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Duree).IsRequired();
            builder.HasOne(t => t.Utilisateur)
                   .WithMany(u => u.Temps)
                   .HasForeignKey(t => t.UtilisateurId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

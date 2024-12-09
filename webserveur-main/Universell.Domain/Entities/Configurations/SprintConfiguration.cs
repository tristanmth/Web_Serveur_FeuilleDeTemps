using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universell.Domain.Entities;

namespace Universell.Domain.Entities.Configurations
{
    public class SprintConfiguration : IEntityTypeConfiguration<Sprint>
    {
        public void Configure(EntityTypeBuilder<Sprint> builder)
        {
            builder.ToTable("Sprints");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Nom).IsRequired().HasMaxLength(100);
            builder.Property(s => s.DateDebut).IsRequired();
            builder.Property(s => s.DateFin).IsRequired();
            builder.HasMany(s => s.Membres)
                   .WithMany(u => u.Sprints);
        }
    }
}
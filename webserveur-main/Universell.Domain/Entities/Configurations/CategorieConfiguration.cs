using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities.Configurations
{
    public class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Parent)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.ParentId);
        }
    }

}

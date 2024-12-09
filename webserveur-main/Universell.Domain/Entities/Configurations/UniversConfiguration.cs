using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities.Configurations
{
    public class UniversConfiguration : IEntityTypeConfiguration<Univers>
    {
        public void Configure(EntityTypeBuilder<Univers> builder)
        {
            builder.ToTable("Univers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nom).IsRequired();
        }
    }
}

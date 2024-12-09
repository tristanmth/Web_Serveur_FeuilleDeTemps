using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universell.Domain.Entities.Configurations
{
    public class ContactMessageConfiguration : IEntityTypeConfiguration<ContactMessage>
    {
        public void Configure(EntityTypeBuilder<ContactMessage> builder)
        {
            builder.ToTable("ContactMessage");
            builder.HasKey(cm => cm.Id);
            builder.Property(cm => cm.Sujet).IsRequired();
            builder.Property(cm => cm.Contenu).IsRequired();
            builder.Property(cm => cm.AdresseMail).IsRequired();
            builder.Property(cm => cm.DateEnvoi).IsRequired();
        }
    }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Molntjanster.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molntjanster.Data
{
    public class BaseEntityConfiguration<T> where T : BaseEntity
    {
        public static void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Uid)
                .IsRequired()
                .HasDefaultValueSql(MolntjansterContext.NEWID);

            builder.HasIndex(x => x.Uid)
                .IsUnique();

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql(MolntjansterContext.SYSDATETIMEOFFSET);
        }
    }
}

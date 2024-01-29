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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            BaseEntityConfiguration<Student>.Configure(builder);

            builder.Property(x => x.StudentName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Email) 
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => new { x.StudentName, x.Email })
                .IsUnique();
        }
    }
}

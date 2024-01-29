using Microsoft.EntityFrameworkCore;
using Molntjanster.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molntjanster.Data
{
    public class MolntjansterContext : DbContext
    {
        public MolntjansterContext(DbContextOptions<MolntjansterContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }


        public const string SYSDATETIMEOFFSET = "SYSDATETIMEOFFSET()";
        public const string NEWID = "NEWID()";
        public const string SUSER_SNAME = "SUSER_SNAME()";
    }
}

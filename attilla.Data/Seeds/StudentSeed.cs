using attilla.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attilla.Data.Seeds
{
    internal class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                   new Student { StudentId = 1, Name = "ahmet" },
                   new Student { StudentId = 2, Name = "veli" },
                   new Student { StudentId = 3, Name = "ali" }
                   );
        }
    }
}

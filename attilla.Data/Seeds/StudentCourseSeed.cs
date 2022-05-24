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
    internal class StudentCourseSeed : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasData(
                   new StudentCourse { StudentId = 1, CourseId = 1 },
                   new StudentCourse { StudentId = 2, CourseId = 2 },
                   new StudentCourse { StudentId = 3, CourseId = 3 }
                   );
        }
    }
}

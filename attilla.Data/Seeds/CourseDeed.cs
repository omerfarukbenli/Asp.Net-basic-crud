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
    internal class CourseDeed : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                    new Course { CourseId = 1, CourseName = "türkçe", Description="türkçe dersi anlatılır" },
                    new Course { CourseId = 2, CourseName = "matematik", Description = "matematik dersi anlatılır" },
                    new Course { CourseId = 3, CourseName = "sosyal", Description = "sosyal dersi anlatılır" }
                    );
        }
    }
}

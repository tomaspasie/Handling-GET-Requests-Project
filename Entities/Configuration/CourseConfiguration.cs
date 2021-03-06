using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData
            (
                new Course
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                    CourseName = "Advanced Web Applications",
                },
                new Course
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce1"),
                    CourseName = "Web Mining",
                }
            );
        }
    }
}
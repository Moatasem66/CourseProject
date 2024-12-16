using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
using System.Reflection.Emit;

namespace CourseProject.Configurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Instructors)
            .HasForeignKey(x => x.DepartmentId);

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
using System.Reflection.Emit;

namespace CourseProject.Configurations;

public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder
            .HasOne(s => s.Student)
            .WithMany(e => e.Enrollments)
            .HasForeignKey(sc => sc.StudentId);

        builder
            .HasOne(c => c.Course)
            .WithMany(e => e.Enrollments)
            .HasForeignKey(e => e.CourseId);
            
    }
}

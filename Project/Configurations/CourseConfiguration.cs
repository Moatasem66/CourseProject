using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
namespace CourseProject.Configurations;
public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder
            .HasOne(c => c.ClassRoom)
            .WithOne(c => c.Course)
            .HasForeignKey<Course>(c => c.ClassRoomId)
            .IsRequired(false);


        builder
            .HasOne(x => x.Department)
            .WithMany(x => x.Courses)
            .HasForeignKey(x => x.DepartmentId);

        builder
          .HasOne(x => x.Instructor)
          .WithMany(x => x.Courses)
          .HasForeignKey(x => x.InstructorId)
          .OnDelete(DeleteBehavior.Restrict);

       
    }
}

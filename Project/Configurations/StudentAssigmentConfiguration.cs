using CourseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
namespace CourseProject.Configurations;

public class StudentAssigmentConfiguration : IEntityTypeConfiguration<StudentAssigment>
{
    public void Configure(EntityTypeBuilder<StudentAssigment> builder)
    {
        builder.HasKey(
             x => new
             {
                 x.StudentId,
                 x.AssignmentId
             });

        builder
            .HasOne(s => s.Student)
            .WithMany(x => x.StudentAssigments)
            .HasForeignKey(c => c.StudentId)
            .OnDelete(DeleteBehavior.Cascade) ;

        builder
            .HasOne(s => s.Assignment)
            .WithMany(x => x.StudentAssignments)
            .HasForeignKey(c => c.AssignmentId)
            .OnDelete(DeleteBehavior.Cascade);
           
    }
}

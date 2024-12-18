using CourseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
namespace CourseProject.Configurations;

public class StudentAssigmentConfiguration : IEntityTypeConfiguration<StudentAssignment>
{
    public void Configure(EntityTypeBuilder<StudentAssignment> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasIndex(x => new
            {
                x.AssignmentId,
                x.StudentId
            })
            .IsUnique();

        builder
            .HasOne(s => s.Student)
            .WithMany(x => x.StudentAssignments)
            .HasForeignKey(c => c.StudentId)
            .OnDelete(DeleteBehavior.Cascade) ;

        builder
            .HasOne(s => s.Assignment)
            .WithMany(x => x.StudentAssignment)
            .HasForeignKey(c => c.AssignmentId)
            .OnDelete(DeleteBehavior.Cascade);
           
    }
}

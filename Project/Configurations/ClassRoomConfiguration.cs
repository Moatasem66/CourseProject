using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
using System.Reflection.Emit;

namespace CourseProject.Configurations;

public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
{
    public void Configure(EntityTypeBuilder<ClassRoom> builder)
    {
        
    }
}

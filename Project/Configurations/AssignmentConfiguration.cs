﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities;
using System.Reflection.Emit;

namespace CourseProject.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
   
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder
            .HasOne(x => x.Course)
            .WithMany(a => a.Assignments)
            .HasForeignKey(x=> x.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.ToTable("Assignments");
    }
}

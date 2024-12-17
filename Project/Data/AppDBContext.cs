using CourseProject.Configurations;
using CourseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Project.Entities;
using System.Reflection;

namespace Project.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {

    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<StudentAssigment> StudentAssigments { get; set; }  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}

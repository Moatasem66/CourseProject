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
    //public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Department> Departments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

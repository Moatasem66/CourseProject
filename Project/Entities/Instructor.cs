using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public int DepartmentId { get; set; }
    public Department? Department { get; set; } = default!;
    public ICollection<Course>? Courses { get; set; } = default!;


}

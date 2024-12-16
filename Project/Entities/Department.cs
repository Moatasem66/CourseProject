namespace Project.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty ;
    public ICollection<Course>? Courses { get; set; } = default!;
    public ICollection<Instructor>? Instructors { get; set; } = default!;

}

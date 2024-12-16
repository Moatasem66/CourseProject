namespace Project.Entities;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CourseHour { get; set; }
    public int DepartmentId { get; set; }
    public int ClassRoomId { get; set; }
    public int InstructorId { get; set; }
    public ClassRoom? ClassRoom { get; set; }
    public Department? Department { get; set; } = default!;
    public Instructor? Instructor { get; set; } = default!;


}

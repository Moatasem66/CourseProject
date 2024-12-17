using CourseProject.Entities;

namespace Project.Entities;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CourseHour { get; set; }
    public int DepartmentId { get; set; }
    public int? ClassRoomId { get; set; }
    public int InstructorId { get; set; }
    public virtual ClassRoom? ClassRoom { get; set; }
    public virtual Department? Department { get; set; } = default!;
    public virtual Instructor? Instructor { get; set; } = default!;
    public virtual ICollection<Enrollment>? Enrollments { get; set; } = default!;
    public virtual ICollection<Assignment>? Assignments { get; set; } = default!;


}

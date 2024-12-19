using Project.Entities;
using Project.Services;

namespace CourseProject.Entities;

public class StudentAssignment
{
    public int  Id { get; set; }
    public int StudentId { get; set; }
    public int AssignmentId { get; set; }
    public DateOnly? SubmissionDate { get; set; }
    public Student? Student { get; set; } = default!;
    public Assignment? Assignment { get; set; } = default!;

}

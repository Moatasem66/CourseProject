using CourseProject.Contracts;
using CourseProject.Entities;
using Project.Data;
using Project.Entities;

namespace CourseProject.Services;

public class StudentAssignmentService  : IStudentAssignmentService
{
    private readonly AppDBContext _context;
    public StudentAssignmentService(AppDBContext DBContext)
    {
        _context = DBContext;
    }
    /// <inheritdoc/>
    public StudentAssignment CreateStudentAssignment(StudentAssignment StudentAssignment)
    {
        try
        {
            if (CheckStudentEnrollToAssignmentCourse(StudentAssignment.StudentId, StudentAssignment.AssignmentId))
            {
                _context.StudentAssignments.Add(StudentAssignment);
                _context.SaveChanges();
                return StudentAssignment;
            }
            return new StudentAssignment();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteStudentAssignment(int Id)
    {
        try
        {
            var StudentAssignment = GetStudentAssignmentById(Id);
            if (StudentAssignment is null)
                return false;

            _context.Remove(StudentAssignment);
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
       

    }
    /// <inheritdoc/>
    public List<StudentAssignment> GetAllStudentAssignments()
    {
        return _context.StudentAssignments.ToList();
    }

    public StudentAssignment? GetStudentAssignmentById(int Id)
    {
        var StudentAssignment = _context.StudentAssignments.Find(Id);
        return StudentAssignment ?? null;
    }
    /// <inheritdoc/>
    public bool UpdateStudentAssignment(int Id, StudentAssignment StudentAssignment)
    {
        try
        {
            var CurrentStudentAssignment = GetStudentAssignmentById(Id);
            if (CurrentStudentAssignment is null)
                return false;
            
            if (CheckStudentEnrollToAssignmentCourse(StudentAssignment.StudentId, StudentAssignment.AssignmentId))
            {
                CurrentStudentAssignment.StudentId = StudentAssignment.StudentId;
                CurrentStudentAssignment.AssignmentId = StudentAssignment.AssignmentId;
                CurrentStudentAssignment.SubmissionDate = StudentAssignment.SubmissionDate;
                _context.SaveChanges();
                return true;

            }
            return false;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    private bool CheckStudentEnrollToAssignmentCourse(int StudentId, int AssignmentId)
    {
        try
        {
            var Assignment = _context.Assignments.Find(AssignmentId);
            if(Assignment is null)
                return false;
            var Enrollment = _context.Enrollments.FirstOrDefault(x => x.StudentId == StudentId && x.CourseId == Assignment.CourseId);
            if (Enrollment is null)
                return false;
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}

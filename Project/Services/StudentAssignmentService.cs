using CourseProject.Contracts;
using CourseProject.Entities;
using Project.Data;
using Project.Entities;

namespace CourseProject.Services;

public class StudentAssignmentService  : IStudentAssignmentService
{
    private readonly AppDBContext _context;
    public StudentAssignmentService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public StudentAssignment CreateStudentAssignment(StudentAssignment StudentAssignment)
    {
        try
        {
            _context.StudentAssignments.Add(StudentAssignment);
            _context.SaveChanges();
            return StudentAssignment;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteStudentAssignment(int Id)
    {
        var StudentAssignment = _context.StudentAssignments.Find(Id);
        if (StudentAssignment is null)
            return false;

        _context.Remove(StudentAssignment);
        _context.SaveChanges();
        return true;

    }
    /// <inheritdoc/>
    public List<StudentAssignment> GetAllStudentAssignments()
    {
        return _context.StudentAssignments.ToList();
    }

    public StudentAssignment GetStudentAssignmentById(int Id)
    {
        var StudentAssignment = _context.StudentAssignments.Find(Id);
        return StudentAssignment;
    }
    /// <inheritdoc/>
    public bool UpdateStudentAssignment(int Id, StudentAssignment StudentAssignment)
    {
        try
        {
            var CurrentStudentAssignment = _context.StudentAssignments.Find(Id);
            if (CurrentStudentAssignment is null)
                return false;

            //CurrentStudentAssignment.Name = StudentAssignment.Name;
            //CurrentStudentAssignment.Capacity = StudentAssignment.Capacity;
            //CurrentStudentAssignment.Location = StudentAssignment.Location;


            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

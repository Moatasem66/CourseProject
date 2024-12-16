using Project.Contracts;
using Project.Data;
using Project.Entities;

namespace CourseProject.Services;

public class InstructorService : IInstructorService
{
    private readonly AppDBContext _context;
    public InstructorService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public Instructor CreateInstructor(Instructor Instructor)
    {
        try
        {
            _context.Instructors.Add(Instructor);
            _context.SaveChanges();
            return Instructor;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteInstructor(int Id)
    {
        var Instructor = _context.Instructors.Find(Id);
        if (Instructor is null)
            return false;

        _context.Remove(Instructor);
        _context.SaveChanges();
        return true;

    }
    /// <inheritdoc/>
    public List<Instructor> GetAllInstructors()
    {
        return _context.Instructors.ToList();
    }

    public Instructor GetInstructorById(int Id)
    {
        var Instructor = _context.Instructors.Find(Id);
        return Instructor;
    }
    /// <inheritdoc/>
    public bool UpdateInstructor(int Id, Instructor Instructor)
    {
        try
        {
            var CurrentInstructor = _context.Instructors.Find(Id);
            if (CurrentInstructor is null)
                return false;

            CurrentInstructor.Name = Instructor.Name;
            CurrentInstructor.Email = Instructor.Email;
            CurrentInstructor.Specialization = Instructor.Specialization;
            CurrentInstructor.DepartmentId = Instructor.DepartmentId;

            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

using CourseProject.Contracts;
using Project.Data;
using Project.Entities;
namespace CourseProject.Services;
public class StudentService : IStudentService
{
    private readonly AppDBContext _context;
    public StudentService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public Student? GetStudentById(int Id)
    {
        if (Id == 0)
            return null;
        var Student = _context.Students.Find(Id);
        return Student is null  ? null  : Student;
    }
    /// <inheritdoc/>
    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }
    /// <inheritdoc/>
    public Student CreateStudent(Student Student)
    {
        try
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
            return Student;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteStudent(int Id)
    {
        var Student = GetStudentById(Id);
        if (Student is null)
            return false;

        _context.Remove(Student);
        _context.SaveChanges();
        return true;

    } 
    /// <inheritdoc/>
    public bool UpdateStudent(int Id, Student Student)
    {
        try
        {
            var CurrentStudent = GetStudentById(Id);
            if (CurrentStudent is null)
                return false;

            CurrentStudent.Name = Student.Name;
            CurrentStudent.Email = Student.Email;
            CurrentStudent.PhoneNumber = Student.PhoneNumber;
            CurrentStudent.Address = Student.Address;


            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

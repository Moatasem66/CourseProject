using CourseProject.Contracts;
using Project.Data;
using Project.Entities;

namespace CourseProject.Services;

public class DepartmentService : IDepartmentService
{
    private readonly AppDBContext _context;
    public DepartmentService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public Department CreateDepartment(Department Department)
    {
        try
        {
            _context.Departments.Add(Department);
            _context.SaveChanges();
            return Department;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteDepartment(int Id)
    {
        var Department = _context.Departments.Find(Id);
        if (Department is null)
            return false;

        _context.Remove(Department);
        _context.SaveChanges();
        return true;

    }
    /// <inheritdoc/>
    public List<Department> GetAllDepartments()
    {
        return _context.Departments.ToList();
    }

    public Department GetDepartmentById(int Id)
    {
        var Department = _context.Departments.Find(Id);

        return Department;
    }
    /// <inheritdoc/>
    public bool UpdateDepartment(int Id, Department Department)
    {
        try
        {
            var CurrentDepartment = _context.Departments.Find(Id);
            if (CurrentDepartment is null)
                return false;

            CurrentDepartment.Name = Department.Name;
            CurrentDepartment.Description = Department.Description;

            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

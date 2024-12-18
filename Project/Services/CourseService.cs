using CourseProject.Contracts;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Entities;

namespace Project.Services;

public class CourseService : ICourseService
{
    private readonly AppDBContext _context;
    public CourseService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public Course CreateCourse(Course Course)
    {
        try
        {
            _context.Courses.Add(Course);
            _context.SaveChanges();
            return Course;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteCourse(int Id)
    {
        var Course = _context.Courses.Find(Id);
        if(Course is null) 
            return false;
        
        _context.Remove(Course);
        _context.SaveChanges();
        return true;
        
    }
    /// <inheritdoc/>
    public List<Course> GetAllCourses()
    {
        var result = _context.Courses.ToList();
        return result;
    }

    public Course GetCourseById(int Id)
    {
        var Course = _context.Courses.Find(Id);
        return Course;
    }
    /// <inheritdoc/>
    public bool UpdateCourse(int Id, Course Course)
    {
        try
        {
            var CurrentCourse = _context.Courses.Find(Id);
            if (CurrentCourse is null)
                return false;

            CurrentCourse.Title = Course.Title;
            CurrentCourse.Description = Course.Description;
            CurrentCourse.CourseHour = Course.CourseHour;
            CurrentCourse.ClassRoomId = Course.ClassRoomId;
            CurrentCourse.InstructorId = Course.InstructorId;
            CurrentCourse.DepartmentId =  Course.DepartmentId;

            
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

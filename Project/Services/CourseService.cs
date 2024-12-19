using CourseProject.Contracts;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Entities;

namespace Project.Services;

public class CourseService : ICourseService
{
    private readonly AppDBContext _context;
    public CourseService(AppDBContext DBContext)
    {
        _context = DBContext;
    }
    /// <inheritdoc/>
    public Course? GetCourseById(int Id)
    {
        var Course = _context.Courses.Find(Id);
      
        return Course ?? null;
    }

    /// <inheritdoc/>
    public List<Course> GetAllCourses()
    {
        var CoursesList = _context.Courses.ToList();
        
        return CoursesList;
    }

    /// <inheritdoc/>
    public Course? CreateCourse(Course Course)
    {
        try
        {
            if(CheckAssignedToThisDepartment(Course.InstructorId , Course.DepartmentId))
            {
                _context.Courses.Add(Course);
                _context.SaveChanges();
                return Course;
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
  
    /// <inheritdoc/>
    public bool UpdateCourse(int Id, Course Course)
    {
        try
        {
            var CurrentCourse = GetCourseById(Id);
            if (CurrentCourse is null)
                return false;
            if (CheckAssignedToThisDepartment(Course.DepartmentId, Course.DepartmentId))
            {
                CurrentCourse.Title = Course.Title;
                CurrentCourse.Description = Course.Description;
                CurrentCourse.CourseHour = Course.CourseHour;
                CurrentCourse.ClassRoomId = Course.ClassRoomId;
                CurrentCourse.InstructorId = Course.InstructorId;
                CurrentCourse.DepartmentId = Course.DepartmentId;
                _context.SaveChanges();
                return true;
            }
            return false ;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteCourse(int Id)
    {
        var Course = GetCourseById(Id);
        if (Course is null)
            return false;

        _context.Remove(Course);
        _context.SaveChanges();
        return true;

    }
    private bool CheckAssignedToThisDepartment (int InstructorId , int DepartmentId)
    {
        var Instructor = _context.Instructors.Find(InstructorId);
        if(Instructor is null)
            return false;
        return Instructor.DepartmentId == DepartmentId;
    }
}

using Project.Entities;

namespace CourseProject.Contracts;

public interface ICourseService
{
    /// <summary>
    /// method to Create new Course 
    /// </summary>
    /// <param name="Course">Course</param>
    /// <returns>Course</returns>
    Course CreateCourse(Course Course);
    /// <summary>
    /// method to Update Course 
    /// </summary>
    /// <param name="Id"> Course id </param>
    /// <param name="Course"> Course Object </param>
    /// <returns>bool</returns>
    bool UpdateCourse(int Id, Course Course);
    /// <summary>
    /// method to Delete Course  
    /// </summary>
    /// <param name="CourseId"></param>
    /// <returns>bool</returns>
    bool DeleteCourse(int Id);
    /// <summary>
    /// method to Get student  by id 
    /// </summary>
    /// <param name="CourseId"></param>
    /// <returns>Student</returns>
    Course GetCourseById(int Id);
    /// <summary>
    /// method to Get List Courses  
    /// </summary>
    /// <returns>list of Courses </returns>
    List<Course> GetAllCourses();
}


using Project.Entities;

namespace CourseProject.Contracts;

public interface IStudentService
{
    /// <summary>
    /// method to Get Student  by id 
    /// </summary>
    /// <param name="StudentId"></param>
    Student GetStudentById(int StudentId);
    /// <summary>
    /// method to Get List Student  
    /// </summary>
    /// <returns>list of Students </returns>
    List<Student> GetAllStudents();
    /// <summary>
    /// method to Create new Student 
    /// </summary>
    /// <param name="Student"></param>
    /// <returns>Student</returns>
    Student? CreateStudent(Student Student);
    /// <summary>
    /// method to Update Student 
    /// </summary>
    /// <param name="Student"></param>
    /// <returns>bool</returns>
    bool UpdateStudent(int Id, Student Student);
    /// <summary>
    /// method to Delete Student  
    /// </summary>
    /// <param name="StudentId"></param>
    /// <returns>bool</returns>
    bool DeleteStudent(int StudentId);
}

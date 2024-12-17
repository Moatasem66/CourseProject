using CourseProject.Entities;
using Project.Entities;

namespace CourseProject.Contracts;

public interface IStudentAssignmentService
{
    /// <summary>
    /// method to Get StudentAssignment  by id 
    /// </summary>
    /// <param name="StudentAssignmentId"></param>
    StudentAssignment GetStudentAssignmentById(int StudentAssignmentId);
    /// <summary>
    /// method to Get List StudentAssignment  
    /// </summary>
    /// <returns>list of StudentAssignments </returns>
    List<StudentAssignment> GetAllStudentAssignments();
    /// <summary>
    /// method to Create new StudentAssignment 
    /// </summary>
    /// <param name="StudentAssignment"></param>
    /// <returns>StudentAssignment</returns>
    StudentAssignment CreateStudentAssignment(StudentAssignment StudentAssignment);
    /// <summary>
    /// method to Update StudentAssignment 
    /// </summary>
    /// <param name="StudentAssignment"></param>
    /// <returns>bool</returns>
    bool UpdateStudentAssignment(int Id, StudentAssignment StudentAssignment);
    /// <summary>
    /// method to Delete StudentAssignment  
    /// </summary>
    /// <param name="StudentAssignmentID"></param>
    /// <returns>bool</returns>
    bool DeleteStudentAssignment(int StudentAssignmentId);
}

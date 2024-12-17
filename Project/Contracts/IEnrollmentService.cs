using Project.Entities;

namespace CourseProject.Contracts;

public interface IEnrollmentService
{
    /// <summary>
    /// method to Get Enrollment  by id 
    /// </summary>
    /// <param name="EnrollmentId"></param>
    Enrollment GetEnrollmentById(int EnrollmentId);
    /// <summary>
    /// method to Get List Enrollment  
    /// </summary>
    /// <returns>list of Enrollments </returns>
    List<Enrollment> GetAllEnrollments();
    /// <summary>
    /// method to Create new Enrollment 
    /// </summary>
    /// <param name="Enrollment"></param>
    /// <returns>Enrollment</returns>
    Enrollment CreateEnrollment(Enrollment Enrollment);
    /// <summary>
    /// method to Update Enrollment 
    /// </summary>
    /// <param name="Enrollment"></param>
    /// <returns>bool</returns>
    bool UpdateEnrollment(int Id, Enrollment Enrollment);
    /// <summary>
    /// method to Delete Enrollment  
    /// </summary>
    /// <param name="EnrollmentID"></param>
    /// <returns>bool</returns>
    bool DeleteEnrollment(int EnrollmentId);
}

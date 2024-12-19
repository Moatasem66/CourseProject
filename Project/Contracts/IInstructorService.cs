using Project.Entities;
namespace Project.Contracts;
public interface IInstructorService
{
    /// <summary>
    /// method to Get Instructor  by id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>Instructor or null</returns>
    Instructor? GetInstructorById(int Id);
    /// <summary>
    /// method to Get List Instructor  
    /// </summary>
    /// <returns>list of Instructors </returns>
    List<Instructor> GetAllInstructors();
    /// <summary>
    /// method to Create new Instructor 
    /// </summary>
    /// <param name="Instructor"></param>
    /// <returns>Instructor</returns>
    Instructor CreateInstructor(Instructor Instructor);
    /// <summary>
    /// method to Update Instructor 
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Instructor"></param>
    /// <returns>bool</returns>
    bool UpdateInstructor(int Id, Instructor Instructor);
    /// <summary>
    /// method to Delete Instructor  
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>bool</returns>
    bool DeleteInstructor(int Id);
    
}

using Project.Entities;

namespace CourseProject.Contracts;

public interface IDepartmentService
{
    /// <summary>
    /// method to Get Department  by id 
    /// </summary>
    /// <param name="DepartmentId"></param>
    Department GetDepartmentById(int Id);
    /// <summary>
    /// method to Get List Department  
    /// </summary>
    /// <returns>list of Departments </returns>
    List<Department> GetAllDepartments();
    /// <summary>
    /// method to Create new Department 
    /// </summary>
    /// <param name="Department"></param>
    /// <returns>Department</returns>
    Department CreateDepartment(Department Department);
    /// <summary>
    /// method to Update Department 
    /// </summary>
    /// <param name="Department"></param>
    /// <returns>bool</returns>
    bool UpdateDepartment(int Id, Department Department);
    /// <summary>
    /// method to Delete Department  
    /// </summary>
    /// <param name="DepartmentID"></param>
    /// <returns>bool</returns>
    bool DeleteDepartment(int DepartmentId);
}

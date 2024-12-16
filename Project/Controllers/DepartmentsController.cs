using CourseProject.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentService _departmentService;
    public DepartmentsController(IDepartmentService DepartmentService)
    {
        _departmentService = DepartmentService;
    }
    [HttpGet]
    [Route("GetDepartmentById")]
    public IActionResult GetDepartmentById(int Id)
    {
        var ResponseDepartment = _departmentService.GetDepartmentById(Id);

        return ResponseDepartment is null ? NotFound() : Ok(ResponseDepartment);
    }
    [HttpGet]
    [Route("GetAllDepartments")]
    public IActionResult GetAllDepartments()
    {
        var DepartmentsList = _departmentService.GetAllDepartments();

        return DepartmentsList == null ? BadRequest() : Ok(DepartmentsList);
    }

    [HttpPost]
    [Route("Department_Create")]
    public IActionResult CreateDepartment(Department Department)
    {
        var ResponseDepartment = _departmentService.CreateDepartment(Department);

        return ResponseDepartment is null ? BadRequest("Error Happen ") : Ok(Department);
    }
    [HttpPut]
    [Route("Department_Update/{Id}")]
    public IActionResult UpdateDepartment(int Id, Department Department)
    {
        var ResponseDepartment = _departmentService.UpdateDepartment(Id, Department);

        return ResponseDepartment == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("Department_Delete")]
    public IActionResult DeleteDepartment(int Id)
    {
        var ResponseDepartment = _departmentService.DeleteDepartment(Id);

        return ResponseDepartment == false ? BadRequest() : NoContent();
    }
}

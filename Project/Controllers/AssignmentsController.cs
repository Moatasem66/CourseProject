using CourseProject.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Contracts;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AssignmentsController : ControllerBase
{
    private readonly IAssignmentService _AssignmentService;
    public AssignmentsController(IAssignmentService AssignmentService)
    {
        _AssignmentService = AssignmentService;
    }
    [HttpGet]
    [Route("getbyid")]
    public IActionResult GetAssignmentById(int Id)
    {
        var ResponseAssignment = _AssignmentService.GetAssignmentById(Id);

        return ResponseAssignment is null ? NotFound() : Ok(ResponseAssignment);
    }
    [HttpGet]
    [Route("getall")]
    public IActionResult GetAllAssignments()
    {
        var AssignmentsList = _AssignmentService.GetAllAssignments();

        return AssignmentsList == null ? BadRequest() : Ok(AssignmentsList);
    }

    [HttpPost]
    [Route("createAssignment")]
    public IActionResult CreateAssignment(Assignment Assignment)
    {
        var ResponseAssignment = _AssignmentService.CreateAssignment(Assignment);

        return ResponseAssignment is null ? BadRequest("Error Happen ") : Ok(Assignment);
    }
    [HttpPut]
    [Route("updateAssignment/{Id}")]
    public IActionResult UpdateAssignment(int Id, Assignment Assignment)
    {
        var ResponseAssignment = _AssignmentService.UpdateAssignment(Id, Assignment);

        return ResponseAssignment == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deleteAssignment/{id}")]
    public IActionResult DeleteAssignment(int Id)
    {
        var ResponseAssignment = _AssignmentService.DeleteAssignment(Id);

        return ResponseAssignment == false ? BadRequest() : NoContent();
    }
}

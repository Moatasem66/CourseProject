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
    private readonly IAssignmentService _assignmentService;
    public AssignmentsController(IAssignmentService AssignmentService)
    {
        _assignmentService = AssignmentService;
    }
    [HttpGet]
    [Route("getassignmentbyid")]
    public IActionResult GetAssignmentById(int Id)
    {
        var ResponseAssignment = _assignmentService.GetAssignmentById(Id);

        return ResponseAssignment is null ? NotFound() : Ok(ResponseAssignment);
    }
    [HttpGet]
    [Route("getallassignments")]
    public IActionResult GetAllAssignments()
    {
        var AssignmentsList = _assignmentService.GetAllAssignments();

        return AssignmentsList == null ? BadRequest() : Ok(AssignmentsList);
    }

    [HttpPost]
    [Route("createassignment")]
    public IActionResult CreateAssignment(Assignment Assignment)
    {
        var ResponseAssignment = _assignmentService.CreateAssignment(Assignment);

        return ResponseAssignment is null ? BadRequest("Error Happen ") : Ok(ResponseAssignment);
    }
    [HttpPut]
    [Route("updateassignment/{Id}")]
    public IActionResult UpdateAssignment(int Id, Assignment Assignment)
    {
        var ResponseAssignment = _assignmentService.UpdateAssignment(Id, Assignment);

        return ResponseAssignment == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deleteassignment/{Id}")]
    public IActionResult DeleteAssignment(int Id)
    {
        var ResponseAssignment = _assignmentService.DeleteAssignment(Id);

        return ResponseAssignment == false ? BadRequest() : NoContent();
    }
}

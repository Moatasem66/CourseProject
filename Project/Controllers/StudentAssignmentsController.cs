﻿using CourseProject.Contracts;
using CourseProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Contracts;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentAssignmentsController : ControllerBase
{
    private readonly IStudentAssignmentService _studentAssignmentService;
    public StudentAssignmentsController(IStudentAssignmentService StudentAssignmentService)
    {
        _studentAssignmentService = StudentAssignmentService;
    }
    [HttpGet]
    [Route("getbyid")]
    public IActionResult GetStudentAssignmentById(int Id)
    {
        var ResponseStudentAssignment = _studentAssignmentService.GetStudentAssignmentById(Id);

        return ResponseStudentAssignment is null ? NotFound() : Ok(ResponseStudentAssignment);
    }
    [HttpGet]
    [Route("getall")]
    public IActionResult GetAllStudentAssignments()
    {
        var StudentAssignmentsList = _studentAssignmentService.GetAllStudentAssignments();

        return StudentAssignmentsList == null ? BadRequest() : Ok(StudentAssignmentsList);
    }

    [HttpPost]
    [Route("createStudentAssignment")]
    public IActionResult CreateStudentAssignment(StudentAssignment StudentAssignment)
    {
        var ResponseStudentAssignment = _studentAssignmentService.CreateStudentAssignment(StudentAssignment);

        return ResponseStudentAssignment is null ? BadRequest("Error Happen ") : Ok(StudentAssignment);
    }
    [HttpPut]
    [Route("updateStudentAssignment/{Id}")]
    public IActionResult UpdateStudentAssignment(int Id, StudentAssignment StudentAssignment)
    {
        var ResponseStudentAssignment = _studentAssignmentService.UpdateStudentAssignment(Id, StudentAssignment);

        return ResponseStudentAssignment == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deleteStudentAssignment/{id}")]
    public IActionResult DeleteStudentAssignment(int Id)
    {
        var ResponseStudentAssignment = _studentAssignmentService.DeleteStudentAssignment(Id);

        return ResponseStudentAssignment == false ? BadRequest() : NoContent();
    }
}
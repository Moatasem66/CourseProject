﻿using CourseProject.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Contracts;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InstructorsController : ControllerBase
{
    private readonly IInstructorService _InstructorService;
    public InstructorsController(IInstructorService InstructorService)
    {
        _InstructorService = InstructorService;
    }
    [HttpGet]
    [Route("GetInstructorById")]
    public IActionResult GetInstructorById(int Id)
    {
        var ResponseInstructor = _InstructorService.GetInstructorById(Id);

        return ResponseInstructor is null ? NotFound() : Ok(ResponseInstructor);
    }
    [HttpGet]
    [Route("GetAllInstructors")]
    public IActionResult GetAllInstructors()
    {
        var InstructorsList = _InstructorService.GetAllInstructors();

        return InstructorsList == null ? BadRequest() : Ok(InstructorsList);
    }

    [HttpPost]
    [Route("Instructor_Create")]
    public IActionResult CreateInstructor(Instructor Instructor)
    {
        var ResponseInstructor = _InstructorService.CreateInstructor(Instructor);

        return ResponseInstructor is null ? BadRequest("Error Happen ") : Ok(Instructor);
    }
    [HttpPut]
    [Route("Instructor_Update/{Id}")]
    public IActionResult UpdateInstructor(int Id, Instructor Instructor)
    {
        var ResponseInstructor = _InstructorService.UpdateInstructor(Id, Instructor);

        return ResponseInstructor == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("Instructor_Delete")]
    public IActionResult DeleteInstructor(int Id)
    {
        var ResponseInstructor = _InstructorService.DeleteInstructor(Id);

        return ResponseInstructor == false ? BadRequest() : NoContent();
    }
}
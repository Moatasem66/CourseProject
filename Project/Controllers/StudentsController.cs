﻿using CourseProject.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService  _studentService;
    public StudentsController( IStudentService StudentService)
    {
        _studentService= StudentService;
    }
    [HttpGet]
    [Route("getstudentbyid")]
    public IActionResult GetStudentById(int Id)
    {
        var ResponseStudent = _studentService.GetStudentById(Id);

        return ResponseStudent is null ? NotFound() : Ok(ResponseStudent);
    }
    [HttpGet]
    [Route("getallstudents")]
    public IActionResult GetAllStudents()
    {
        var StudentsList = _studentService.GetAllStudents();

        return StudentsList == null ? BadRequest() : Ok(StudentsList);
    }

    [HttpPost]
    [Route("createstudent")]
    public IActionResult CreateStudent(Student Student)
    {
        var ResponseStudent = _studentService.CreateStudent(Student);

        return ResponseStudent is null ? BadRequest("Error Happen ") : Ok(Student);
    }
    [HttpPut]
    [Route("updatestudent/{Id}")]
    public IActionResult UpdateStudent(int Id, Student Student)
    {
        var ResponseStudent = _studentService.UpdateStudent(Id, Student);

        return ResponseStudent == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deletestudent/{Id}")]
    public IActionResult DeleteStudent(int Id)
    {
        var ResponseStudent = _studentService.DeleteStudent(Id);

        return ResponseStudent == false ? BadRequest() : NoContent();
    }
}

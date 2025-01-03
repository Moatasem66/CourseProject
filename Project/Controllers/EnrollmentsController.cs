﻿using CourseProject.Contracts;
using CourseProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;

namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EnrollmentsController : ControllerBase
{
    private readonly IEnrollmentService _enrollmentService;
    public EnrollmentsController(IEnrollmentService EnrollmentService)
    {
        _enrollmentService = EnrollmentService;
    }
    [HttpGet]
    [Route("getenrollmentbyid")]
    public IActionResult GetEnrollmentById(int Id)
    {
        var ResponseEnrollment = _enrollmentService.GetEnrollmentById(Id);

        return ResponseEnrollment is null ? NotFound() : Ok(ResponseEnrollment);
    }
    [HttpGet]
    [Route("getallenrollments")]
    public IActionResult GetAllEnrollments()
    {
        var EnrollmentsList = _enrollmentService.GetAllEnrollments();

        return EnrollmentsList.Count == 0 ? NotFound() : Ok(EnrollmentsList);
    }

    [HttpPost]
    [Route("createenrollment")]
    public IActionResult CreateEnrollment(Enrollment Enrollment)
    {
        var ResponseEnrollment = _enrollmentService.CreateEnrollment(Enrollment);

        return ResponseEnrollment is null ? BadRequest("Error Happen ") : Ok(Enrollment);
    }
    [HttpPut]
    [Route("updateenrollment/{Id}")]
    public IActionResult UpdateEnrollment(int Id, Enrollment Enrollment)
    {
        var ResponseEnrollment = _enrollmentService.UpdateEnrollment(Id, Enrollment);

        return ResponseEnrollment == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deleteenrollment/{Id}")]
    public IActionResult DeleteEnrollment(int Id)
    {
        var ResponseEnrollment = _enrollmentService.DeleteEnrollment(Id);

        return ResponseEnrollment == false ? BadRequest() : NoContent();
    }
}

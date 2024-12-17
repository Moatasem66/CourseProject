using CourseProject.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;
namespace CourseProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly ICourseService _courseService;
    public CoursesController(ICourseService CourseService)
    {
        _courseService = CourseService;
    }
    [HttpGet]
    [Route("getbyid")]
    public IActionResult GetCourseById(int CourseId)
    {
        var ResponseCourse = _courseService.GetCourseById(CourseId);

        return ResponseCourse is null ? NotFound() : Ok(ResponseCourse);
    }
    [HttpGet]
    [Route("getall")]
    public IActionResult GetAllCourses()
    {
        var CoursesList = _courseService.GetAllCourses();

        return CoursesList == null ? BadRequest() : Ok(CoursesList);
    }

    [HttpPost]
    [Route("createcourse")]
    public IActionResult CreateCourse(Course Course)
    {
        var ResponseCourse = _courseService.CreateCourse(Course);

        return ResponseCourse is null ? BadRequest("Error Happen ") : Ok(Course);
    }
    [HttpPut]
    [Route("updatecourse/{Id}")]
    public IActionResult UpdateCourse(int Id, Course Course)
    {
        var ResponseCourse = _courseService.UpdateCourse(Id, Course);

        return ResponseCourse == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("deletecourse/{Id}")]
    public IActionResult DeleteCourse(int Id)
    {
        var ResponseCourse = _courseService.DeleteCourse(Id);

        return ResponseCourse == false ? BadRequest() : NoContent();
    }
}

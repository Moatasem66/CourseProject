﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Contracts;
using Project.Entities;
namespace ClassRoomProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClassRoomController : ControllerBase
{
    private readonly IClassRoomService _classRoomService;
    public ClassRoomController(IClassRoomService ClassRoomService)
    {
        _classRoomService = ClassRoomService;
    }
    [HttpGet]
    [Route("GetClassRoomById")]
    public IActionResult GetClassRoomById(int Id)
    {
        var ResponseClassRoom = _classRoomService.GetClassRoomById(Id);

        return ResponseClassRoom is null ? NotFound() : Ok(ResponseClassRoom);
    }
    [HttpGet]
    [Route("GetAllClassRooms")]
    public IActionResult GetAllClassRooms()
    {
        var ClassRoomsList = _classRoomService.GetAllClassRooms();

        return ClassRoomsList == null ? BadRequest() : Ok(ClassRoomsList);
    }

    [HttpPost]
    [Route("ClassRoom_Create")]
    public IActionResult CreateClassRoom(ClassRoom ClassRoom)
    {
        var ResponseClassRoom = _classRoomService.CreateClassRoom(ClassRoom);

        return ResponseClassRoom is null ? BadRequest("Error Happen ") : Ok(ClassRoom);
    }
    [HttpPut]
    [Route("ClassRoom_Update/{Id}")]
    public IActionResult UpdateClassRoom(int Id, ClassRoom ClassRoom)
    {
        var ResponseClassRoom = _classRoomService.UpdateClassRoom(Id, ClassRoom);

        return ResponseClassRoom == false ? BadRequest() : NoContent();
    }
    [HttpDelete]
    [Route("ClassRoom_Delete")]
    public IActionResult DeleteClassRoom(int Id)
    {
        var ResponseClassRoom = _classRoomService.DeleteClassRoom(Id);

        return ResponseClassRoom == false ? BadRequest() : NoContent();
    }
}
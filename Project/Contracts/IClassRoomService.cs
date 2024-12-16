using Project.Entities;
namespace Project.Contracts;
public interface IClassRoomService
{
    /// <summary>
    /// method to Get ClassRoom  by id 
    /// </summary>
    /// <param name="ClassRoomId"></param>
    ClassRoom GetClassRoomById(int ClassRoomId);
    /// <summary>
    /// method to Get List ClassRoom  
    /// </summary>
    /// <returns>list of ClassRooms </returns>
    List<ClassRoom> GetAllClassRooms();
    /// <summary>
    /// method to Create new ClassRoom 
    /// </summary>
    /// <param name="ClassRoom"></param>
    /// <returns>ClassRoom</returns>
    ClassRoom CreateClassRoom(ClassRoom ClassRoom);
    /// <summary>
    /// method to Update ClassRoom 
    /// </summary>
    /// <param name="ClassRoom"></param>
    /// <returns>bool</returns>
    bool UpdateClassRoom(int Id, ClassRoom ClassRoom);
    /// <summary>
    /// method to Delete ClassRoom  
    /// </summary>
    /// <param name="ClassRoomID"></param>
    /// <returns>bool</returns>
    bool DeleteClassRoom(int ClassRoomId);
    
}

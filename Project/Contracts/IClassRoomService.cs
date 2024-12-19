using Project.Entities;
namespace Project.Contracts;
public interface IClassRoomService
{
    /// <summary>
    /// method to Get ClassRoom by id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>ClassRoom or null </returns>
    ClassRoom? GetClassRoomById(int Id);
    /// <summary>
    /// method to Get List of ClassRoom  
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
    /// <param name="Id"></param>
    /// <param name="ClassRoom"></param>
    /// <returns>bool</returns>
    bool UpdateClassRoom(int Id, ClassRoom ClassRoom);
    /// <summary>
    /// method to Delete ClassRoom  
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>bool</returns>
    bool DeleteClassRoom(int Id);
    
}

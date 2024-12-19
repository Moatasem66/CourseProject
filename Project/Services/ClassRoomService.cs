using Microsoft.EntityFrameworkCore;
using Project.Contracts;
using Project.Data;
using Project.Entities;

namespace ClassRoomProject.Services;

public class ClassRoomService : IClassRoomService
{
    private readonly AppDBContext _context;
    public ClassRoomService(AppDBContext dbContext)
    {
        _context = dbContext;
    }
    /// <inheritdoc/>
    public ClassRoom CreateClassRoom(ClassRoom ClassRoom)
    {
        try
        {
            _context.ClassRooms.Add(ClassRoom);
            _context.SaveChanges();
            return ClassRoom;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteClassRoom(int Id)
    {
        var ClassRoom = _context.ClassRooms.Find(Id);
        if (ClassRoom is null)
            return false;

        _context.Remove(ClassRoom);
        _context.SaveChanges();
        return true;

    }
    /// <inheritdoc/>
    public List<ClassRoom> GetAllClassRooms()
    {
        return _context.ClassRooms.Include(C => C.Course).ToList();
    }

    public ClassRoom GetClassRoomById(int Id)
    {
        //var ClassRoom = _context.ClassRooms.Find(Id);
        var ClassRoom = _context.ClassRooms.Include(C => C.Course).FirstOrDefault(x => x.Id == Id);
        return ClassRoom;
    }
    /// <inheritdoc/>
    public bool UpdateClassRoom(int Id, ClassRoom ClassRoom)
    {
        try
        {
            var CurrentClassRoom = _context.ClassRooms.Find(Id);
            if (CurrentClassRoom is null)
                return false;

            CurrentClassRoom.Name = ClassRoom.Name;
            CurrentClassRoom.Capacity = ClassRoom.Capacity;
            CurrentClassRoom.Location = ClassRoom.Location;


            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

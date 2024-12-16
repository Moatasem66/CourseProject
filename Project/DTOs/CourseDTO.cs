namespace CourseProject.DTOs;
public class CourseDto
{
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CourseHour { get; set; }
    public ClassRoomDto ClassRoom { get; set; }
}

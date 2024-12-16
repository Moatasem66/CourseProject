namespace Project.Entities;

public class ClassRoom
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }
    public Course? Course { get; set; } 
    public int CourseId { get; set; } 
}

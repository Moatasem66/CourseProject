using CourseProject.Entities;
using System;

namespace Project.Entities;
public class Assignment
{
    public Assignment()
    {
        
    }
    public int Id { get; set; }
    public string Title { get; set; } =string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public int CourseId { get; set; }
    public virtual Course Course { get; set; } = new();
    public virtual ICollection<StudentAssigment> StudentAssignments { get; set; } = [];

}
/// <summary> Assignment Have Many Students </summary>
/// <summary> Students have Many Assigmnets </summary>
/// <summary> Assignment Have One Course </summary>
/// <summary> Course Have Many Assgnment </summary>


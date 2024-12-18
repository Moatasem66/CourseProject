using CourseProject.Entities;
using System;

namespace Project.Entities;
public class Assignment
{
   
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Description { get; set; } 
    public DateTime DueDate { get; set; }
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; } 
    public virtual ICollection<StudentAssignment>? StudentAssignment { get; set; } 

}


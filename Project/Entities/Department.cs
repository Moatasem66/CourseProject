﻿namespace Project.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    public ICollection<Course>? Courses { get; set; }
    public ICollection<Instructor>? Instructors { get; set; }

}

﻿using CourseProject.Entities;
using System;

namespace Project.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Email { get; set; }
    public string PhoneNumber { get; set; } 
    public string Address { get; set; } 
    public virtual ICollection<Enrollment>? Enrollments { get; set; } 
    public virtual ICollection<StudentAssignment>? StudentAssignments { get; set; } 
    
}

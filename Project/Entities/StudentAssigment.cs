﻿using Project.Entities;
using Project.Services;

namespace CourseProject.Entities;

public class StudentAssigment
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = default!;

    public int AssignmentId { get; set; }
    public Assignment Assignment { get; set; } = default!;

    public DateTime SubmissionDate { get; set; }
}

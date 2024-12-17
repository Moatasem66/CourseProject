﻿using Project.Entities;

namespace CourseProject.Contracts;

public interface IAssignmentService
{
    /// <summary>
    /// method to Get Assignment  by id 
    /// </summary>
    /// <param name="AssignmentId"></param>
    Assignment GetAssignmentById(int AssignmentId);
    /// <summary>
    /// method to Get List Assignment  
    /// </summary>
    /// <returns>list of Assignments </returns>
    List<Assignment> GetAllAssignments();
    /// <summary>
    /// method to Create new Assignment 
    /// </summary>
    /// <param name="Assignment"></param>
    /// <returns>Assignment</returns>
    Assignment CreateAssignment(Assignment Assignment);
    /// <summary>
    /// method to Update Assignment 
    /// </summary>
    /// <param name="Assignment"></param>
    /// <returns>bool</returns>
    bool UpdateAssignment(int Id, Assignment Assignment);
    /// <summary>
    /// method to Delete Assignment  
    /// </summary>
    /// <param name="AssignmentID"></param>
    /// <returns>bool</returns>
    bool DeleteAssignment(int AssignmentId);
}
﻿using Project.Entities;

namespace CourseProject.Contracts;

public interface IEnrollmentService
{
    /// <summary>
    /// method to Get Enrollment by id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>Enrollment or null</returns>
    Enrollment? GetEnrollmentById(int Id);
    /// <summary>
    /// method to Get List of Enrollments 
    /// </summary>
    /// <returns>list of Enrollments </returns>
    List<Enrollment> GetAllEnrollments();
    /// <summary>
    /// method to Create new Enrollment 
    /// </summary>
    /// <param name="Enrollment"></param>
    /// <returns>Enrollment</returns>
    Enrollment CreateEnrollment(Enrollment Enrollment);
    /// <summary>
    /// method to Update Enrollment 
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Enrollment"></param>
    /// <returns>bool</returns>
    bool UpdateEnrollment(int Id, Enrollment Enrollment);
    /// <summary>
    /// method to Delete Enrollment  
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>bool</returns>
    bool DeleteEnrollment(int Id);
}

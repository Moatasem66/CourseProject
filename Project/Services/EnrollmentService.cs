using CourseProject.Contracts;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Entities;

namespace Project.Services;

public class EnrollmentService : IEnrollmentService
{
    private readonly AppDBContext _context;
    public EnrollmentService(AppDBContext DBContext)
    {
        _context = DBContext;
    }
    /// <inheritdoc/>
    public Enrollment? GetEnrollmentById(int Id)
    {
        var Enrollment = _context.Enrollments.Find(Id);

        return Enrollment ?? null;
    }
    /// <inheritdoc/>
    public List<Enrollment> GetAllEnrollments()
    {
        return _context.Enrollments.ToList();
    }
    /// <inheritdoc/>
    public Enrollment CreateEnrollment(Enrollment Enrollment)
    {
        try
        {
            _context.Enrollments.Add(Enrollment);
            _context.SaveChanges();
            return Enrollment;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteEnrollment(int Id)
    {
        try
        {
            var Enrollment = GetEnrollmentById(Id);
            if (Enrollment is null)
                return false;

            _context.Remove(Enrollment);
            _context.SaveChanges();
            return true;
        }
        catch (InvalidOperationException io)
        {
            throw new Exception(io.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }


    }
    /// <inheritdoc/>
    public bool UpdateEnrollment(int Id, Enrollment Enrollment)
    {
        try
        {
            var CurrentEnrollment = GetEnrollmentById(Id);
            if (CurrentEnrollment is null)
                return false;

            CurrentEnrollment.CourseId = Enrollment.CourseId;
            CurrentEnrollment.StudentId = Enrollment.StudentId;
            CurrentEnrollment.EnrollmentDate = Enrollment.EnrollmentDate;

            _context.SaveChanges();
            return true;
        }
        catch (InvalidOperationException io)
        {
            throw new Exception(io.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

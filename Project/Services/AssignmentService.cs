using CourseProject.Contracts;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Entities;

namespace CourseProject.Services;

public class AssignmentService : IAssignmentService
{
    private readonly AppDBContext _context;
    public AssignmentService(AppDBContext DbContext)
    {
        _context = DbContext;
    }
    /// <inheritdoc/>
    public List<Assignment> GetAllAssignments()
    {
        return _context.Assignments.ToList();
    }
    /// <inheritdoc/>
    public Assignment? GetAssignmentById(int Id)
    {
        var Assignment = _context.Assignments.Find(Id);
        return Assignment ?? null;
    }
    /// <inheritdoc/>
    public Assignment CreateAssignment(Assignment Assignment)
    {
        try
        {
             _context.Assignments.Add(Assignment);
             _context.SaveChanges();
            return Assignment;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    /// <inheritdoc/>
    public bool DeleteAssignment(int Id)
    {
        var Assignment = GetAssignmentById(Id);
        if (Assignment is null)
            return false;

        _context.Remove(Assignment);
        _context.SaveChanges();
        return true;

    }
    
    /// <inheritdoc/>
    public bool UpdateAssignment(int Id, Assignment Assignment)
    {
        try
        {
            var CurrentAssignment = _context.Assignments.Find(Id);
            if (CurrentAssignment is null)
                return false;

            CurrentAssignment.Title = Assignment.Title;
            CurrentAssignment.Description = Assignment.Description;
            CurrentAssignment.DueDate = Assignment.DueDate;
            CurrentAssignment.CourseId = Assignment.CourseId;



            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

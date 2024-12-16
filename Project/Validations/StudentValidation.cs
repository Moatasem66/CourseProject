using FluentValidation;
using FluentValidation.Results;
using Project.Entities;
namespace Project.Validations;
public class StudentValidation :  AbstractValidator<Student>
{
    public StudentValidation()
    {

    }
}

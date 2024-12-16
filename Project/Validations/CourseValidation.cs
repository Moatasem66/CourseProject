using FluentValidation;
using Project.Entities;

namespace Project.Validations;

public class CourseValidation : AbstractValidator<Course>
{
    public CourseValidation()
    {

    }
}

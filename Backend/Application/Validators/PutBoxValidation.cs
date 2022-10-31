using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PutBoxValidation : AbstractValidator<PutBoxDTO>
{
    public PutBoxValidation()
    {
        RuleFor(b => b.Id);
        RuleFor(b => b.Photo).NotEmpty();
        RuleFor(b => b.BoxName).NotEmpty();
        RuleFor(b => b.Description).NotEmpty();
        RuleFor(b => b.Price).Must(b => b > 0);
    }
}
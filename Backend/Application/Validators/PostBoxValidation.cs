using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PostBoxValidation : AbstractValidator<PostBoxDTO>
{
    public PostBoxValidation()
    {
        RuleFor(b => b.Photo).NotEmpty();
        RuleFor(b => b.BoxName).NotEmpty();
        RuleFor(b => b.Description).NotEmpty().MinimumLength(1);
        RuleFor(b => b.Price).Must(b => b > 0);
    }
}
using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PostBoxValidation : AbstractValidator<PostBoxDTO>
{
    public PostBoxValidation()
    {
        RuleFor(b => b.BoxName).NotEmpty();
        RuleFor(b => b.Description).NotEmpty();
        RuleFor(b => b.Price).Must(b => b > 0);
    }
}
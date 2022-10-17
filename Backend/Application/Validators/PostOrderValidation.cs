using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PostOrderValidation : AbstractValidator<PostOrderDTO>
{
    public PostOrderValidation()
    {
        RuleFor(o => o.CustomerId).NotEmpty();
        RuleFor(o => o.BoxId).NotEmpty();
    }
}
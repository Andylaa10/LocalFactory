using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class PutCustomerValidation : AbstractValidator<PutCustomerDTO>
{
    public PutCustomerValidation()
    {
        RuleFor(c => c.Id);
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Email).EmailAddress().NotEmpty();
    }
}
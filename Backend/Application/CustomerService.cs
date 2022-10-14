using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;

namespace Application;

public class CustomerService : ICustomerService
{
    private ICustomerRepository _repository;
    private IMapper _mapper;
    private IValidator<PostCustomerDTO> _postCustomerValidator;
    private IValidator<PutCustomerDTO> _putCustomerValidator;

    public CustomerService(ICustomerRepository repository, 
        IMapper mapper, 
        IValidator<PostCustomerDTO> postCustomerValidator, 
        IValidator<PutCustomerDTO> putCustomerValidator)
    {
        _repository = repository;
        _mapper = mapper;
        _postCustomerValidator = postCustomerValidator;
        _putCustomerValidator = putCustomerValidator;
    }

    public Customer CreateCustomer(PostCustomerDTO cust)
    {
        var validate = _postCustomerValidator.Validate(cust);
        if (!validate.IsValid) throw new ValidationException(validate.Errors.ToString());
        return _repository.CreateCustomer(_mapper.Map<Customer>(cust));
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _repository.GetAllCustomers();
    }

    public Customer GetCustomer(int id)
    {
        return _repository.GetCustomer(id);
    }

    public Customer UpdateCustomer(PutCustomerDTO cust, int id)
    {
        if (id != cust.Id) throw new ValidationException("ID in the body and route are different");
        var validate = _putCustomerValidator.Validate(cust);
        if (!validate.IsValid) throw new ValidationException(validate.Errors.ToString());
        return _repository.UpdateCustomer(_mapper.Map<Customer>(cust), id);
    }

    public Customer DeleteCustomer(int id)
    {
        return _repository.DeleteCustomer(id);
    }
}
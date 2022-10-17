using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;

namespace Application;

public class OrderService : IOrderService
{
    private IOrderRepository _repository;
    private IMapper _mapper;
    private IValidator<PostOrderDTO> _postOrdervalidator;

    public OrderService(IOrderRepository repository,
        IMapper mapper, 
        IValidator<PostOrderDTO> postOrdervalidator)
    {
        _repository = repository;
        _mapper = mapper;
        _postOrdervalidator = postOrdervalidator;
    }

    public Order CreateOrder(PostOrderDTO dto)
    {
        var validate = _postOrdervalidator.Validate(dto);
        if (!validate.IsValid) throw new ValidationException(validate.Errors.ToString());
        return _repository.CreateOrder(_mapper.Map<Order>(dto));
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _repository.GetAllOrders();
    }

    public IEnumerable<Order> GetCustomerOrder(int customerId)
    {
        return _repository.GetCustomerOrder(customerId);
    }
    
    public IEnumerable<Order> GetBoxOrder(int boxId)
    {
        return _repository.GetCustomerOrder(boxId);
    }

    public Order DeleteOrder(int id)
    {
        return _repository.DeleteOrder(id);
    }
}
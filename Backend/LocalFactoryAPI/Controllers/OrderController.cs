using Application.DTOs;
using Application.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(_service.GetAllOrders());
    }
    
    [HttpGet("customer/{customerId}")]
    public IActionResult GetCustomerOrder(int customerId)
    {
        return Ok(_service.GetCustomerOrder(customerId));
    }
    
    [HttpGet("box/{boxId}")]
    public IActionResult GetBoxOrder(int boxId)
    {
        return Ok(_service.GetBoxOrder(boxId));
    }
    
    [HttpPost]
    public IActionResult CreateOrder(PostOrderDTO dto)
    {
        try
        {
            var order = _service.CreateOrder(dto);
            return Created("Order/" + order.Id, order);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteOrder(int id)
    { 
        return Ok(_service.DeleteOrder(id));
    }
}
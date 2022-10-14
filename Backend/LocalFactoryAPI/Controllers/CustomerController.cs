using Application.DTOs;
using Application.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetCustomers()
    {
        return Ok(_service.GetAllCustomers());
    }
        
    [HttpGet("{id}")]
    public IActionResult GetCustomer(int id)
    {
        return Ok(_service.GetCustomer(id));
    }
        
    [HttpPost]
    public IActionResult CreateCustomer(PostCustomerDTO dto)
    {
        try
        {
            var customer = _service.CreateCustomer(dto);
            return Created("Customer/" + customer.Id, customer);
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
        
    [HttpPut("{id}")]
    public IActionResult UpdateCustomer(PutCustomerDTO dto, int id)
    {
        try
        {
            return Ok(_service.UpdateCustomer(dto, id));
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
    public IActionResult DeleteCustomer(int id)
    {
        return Ok(_service.DeleteCustomer(id));
    }
}
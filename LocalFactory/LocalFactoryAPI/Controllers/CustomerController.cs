using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;

[Route("[controller]")]
[ApiController]
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
        throw new NotImplementedException();
    }
        
    [HttpGet("{id}")]
    public IActionResult GetCustomer(int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpPost]
    public IActionResult CreateCustomer(Customer cust)
    {
        throw new NotImplementedException();
    }
        
    [HttpPut("{id}")]
    public IActionResult UpdateCustomer(Customer dto, int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
        throw new NotImplementedException();
    }
    
    
}
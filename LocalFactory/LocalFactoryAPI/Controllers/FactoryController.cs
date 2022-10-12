using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class FactoryController : ControllerBase
{
    private IFactoryService _service;

    public FactoryController(IFactoryService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetFactories()
    {
        throw new NotImplementedException();
    }
        
    [HttpGet("{id}")]
    public IActionResult GetFactory(int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpPost]
    public IActionResult CreateFactory(Factory fac)
    {
        throw new NotImplementedException();
    }
        
    [HttpPut("{id}")]
    public IActionResult UpdateFactory(Factory dto, int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpDelete("{id}")]
    public IActionResult DeleteFactory(int id)
    {
        throw new NotImplementedException();
    }
}
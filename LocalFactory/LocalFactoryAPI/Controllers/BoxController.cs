using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class BoxController : ControllerBase
{
    private IBoxService _service;
    public BoxController(IBoxService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetBoxes()
    {
        throw new NotImplementedException();
    }
        
    [HttpGet("{id}")]
    public IActionResult GetBox(int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpPost]
    public IActionResult CreateBox(Box box)
    {
        throw new NotImplementedException();
    }
        
    [HttpPut("{id}")]
    public IActionResult UpdateBox(Box dto, int id)
    {
        throw new NotImplementedException();
    }
        
    [HttpDelete("{id}")]
    public IActionResult DeleteBox(int id)
    {
        throw new NotImplementedException();
    }
}
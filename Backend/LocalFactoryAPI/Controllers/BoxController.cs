using Application.DTOs;
using Application.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace LocalFactoryAPI.Controllers;
[ApiController]
[Route("[controller]")]
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
        return Ok(_service.GetAllBoxes());
    }
        
    [HttpGet("{id}")]
    public IActionResult GetBox(int id)
    {
        return Ok(_service.GetBox(id));
    }
        
    [HttpPost]
    public IActionResult CreateBox(PostBoxDTO dto)
    {
        try
        {
            var box = _service.CreateBox(dto);
            return Created("Box/" + box.Id, box);
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
    public IActionResult UpdateBox(PutBoxDTO dto, int id)
    {
        try
        {
            return Ok(_service.UpdateBox(dto, id));
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
    public IActionResult DeleteBox(int id)
    { 
        return Ok(_service.DeleteBox(id));
    }

    [HttpGet]
    [Route("rebuildDb")]
    public void RebuildDb()
    {
        _service.RebuildDb();
    }
}
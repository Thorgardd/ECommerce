using System;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Services.Device;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/mouse")]
[ApiController]
public class MouseController : ControllerBase
{
    private MouseService _mouseService;

    public MouseController(MouseService mouseService)
    {
        _mouseService = mouseService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var mouses = _mouseService.GetMouses();
        return Ok(mouses);
    }
    
    [HttpGet("{reference}")]
    public IActionResult Get(string reference)
    {
        var mouseDto = _mouseService.FindByRef(reference);        
        if (mouseDto != null)
            return Ok(new { mouse = mouseDto });
        return NotFound(new { Message = "Réfèrence non trouvée" });
    }

    #endregion
    
    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] MouseDto mouseDto)
    {
        if (mouseDto != null)
        {
            _mouseService.AddMouse(mouseDto);
            return StatusCode(201, mouseDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _mouseService.DelMouse(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
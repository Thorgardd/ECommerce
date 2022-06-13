using System;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Repositories.Device;
using hightqual_it_backend.Services.Device;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/screen")]
[ApiController]
public class ScreenController : ControllerBase
{
    private ScreenService _screenService;

    public ScreenController(ScreenService screenService)
    {
        _screenService = screenService;
    }

    #region Get Methods

    [HttpGet]
    public IActionResult Get()
    {
        var screens = _screenService.GetScreen();
        return Ok(screens);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] ScreenDto screenDto)
    {
        if (screenDto != null)
        {
            _screenService.AddScreen(screenDto);
            return StatusCode(201, screenDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _screenService.DelScreen(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
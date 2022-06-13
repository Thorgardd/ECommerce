using System;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Product;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/os")]
[ApiController]
public class OsController : ControllerBase
{
    private OsService _osService;

    public OsController(OsService osService)
    {
        _osService = osService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var os = _osService.GetAll();
        return Ok(os);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromForm] OsDto osDto)
    {
        if (osDto != null)
        {
            _osService.AddOs(osDto);
            return StatusCode(201, osDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _osService.DelOs(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
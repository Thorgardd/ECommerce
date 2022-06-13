using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/gcard")]
[ApiController]
public class GCardController : ControllerBase
{
    private GCardService _gCardService;

    public GCardController(GCardService gCardService)
    {
        _gCardService = gCardService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var gCard = _gCardService.GetGProd();
        return Ok(gCard);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] GraphicProductDto gCardDto)
    {
        if (gCardDto != null)
        {
            _gCardService.AddGProd(gCardDto);
            return StatusCode(201, gCardDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _gCardService.DelGCard(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
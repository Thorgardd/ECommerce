using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/power")]
[ApiController]
public class PowerSupplyController : ControllerBase
{
    private PowerSupplyService _powerSupplyService;

    public PowerSupplyController(PowerSupplyService powerSupplyService)
    {
        _powerSupplyService = powerSupplyService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var power = _powerSupplyService.GetPowerSupplies();
        return Ok(power);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] PowerSupplyDto powerSupplyDto)
    {
        if (powerSupplyDto != null)
        {
            _powerSupplyService.AddPower(powerSupplyDto);
            return StatusCode(201, powerSupplyDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _powerSupplyService.DelPower(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
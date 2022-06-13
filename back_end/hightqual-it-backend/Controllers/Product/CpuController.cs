using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/cpu")]
[ApiController]
public class CpuController : ControllerBase
{
    private CpuService _cpuService;

    public CpuController(CpuService cpuService)
    {
        _cpuService = cpuService;
    }

    #region Get Methods

    [HttpGet]
    // Verfied
    public IActionResult Get()
    {
        var cpus = _cpuService.GetCpu();
        return Ok(cpus);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    public IActionResult Post([FromBody] CpuDto cpuDto)
    {
        if (cpuDto != null)
        {
            _cpuService.AddCpu(cpuDto);
            return StatusCode(201, cpuDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _cpuService.DelCpu(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
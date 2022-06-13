using System;
using hightqual_it_backend.Dtos;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using hightqual_it_backend.Tools;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/hdisk")]
[ApiController]
[Serializable]
public class HDiskController : ControllerBase
{
    private HDiskService _diskService;

    public HDiskController(HDiskService service)
    {
        _diskService = service;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var hdsik = _diskService.GetHardDisks();
        return Ok(hdsik);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] HardDiskDto hardDiskDto)
    {
        if (hardDiskDto != null)
        {
            _diskService.AddHDisk(hardDiskDto);
            return StatusCode(201, hardDiskDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _diskService.DelDisk(id);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
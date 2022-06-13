
using hightqual_it_backend.Dtos.Motherboard;

using hightqual_it_backend.Services.Device;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/sound")]
[ApiController]
public class SoundController : ControllerBase
{
    private SoundService _soundService;

    public SoundController(SoundService soundService)
    {
        _soundService = soundService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var sounds = _soundService.GetSounds();
        return Ok(sounds);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] SoundDto soundDto)
    {
        if (soundDto != null)
        {
            _soundService.AddSound(soundDto);
            return StatusCode(201, soundDto);
        }
        return BadRequest("ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _soundService.DelSound(id);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/memory")]
[ApiController]
public class MemoryController : ControllerBase
{
    private MemoryService _memoryService;

    public MemoryController(MemoryService memoryService)
    {
        _memoryService = memoryService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var memory = _memoryService.GetMemories();
        return Ok(memory);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    // Verified
    public IActionResult Post([FromBody] MemoryDto memoryDto)
    {
        if (memoryDto != null)
        {
            _memoryService.AddMemory(memoryDto);
            return StatusCode(201, memoryDto);
        }
        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Methods

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _memoryService.DelMemory(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
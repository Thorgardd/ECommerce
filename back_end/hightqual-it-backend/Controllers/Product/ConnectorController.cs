using System;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Services.Device;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Product;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/connector")]
[ApiController]
public class ConnectorController : ControllerBase
{
    private ConnectorService _connectorService;

    public ConnectorController(ConnectorService connectorService)
    {
        _connectorService = connectorService;
    }

    #region Get Methods

    [HttpGet]
    // Verified
    public IActionResult Get()
    {
        var connectors = _connectorService.GetConnectors();
        return Ok(connectors);
    }

    #endregion

    #region Post Methods

    [HttpPost]
    public IActionResult Post([FromBody] ConnectorDto connectorDto)
    {
        if (connectorDto != null)
        {
            _connectorService.AddConnector(connectorDto);
            return StatusCode(201, connectorDto);
        }

        return StatusCode(400, "ERREUR");
    }

    #endregion

    #region Delete Method

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        _connectorService.DelConnector(name);
        return StatusCode(200, "Objet supprimé");
    }

    #endregion
}
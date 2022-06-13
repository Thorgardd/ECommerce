using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using hightqual_it_backend.Dtos.Motherboard;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Repositories.Device;
using hightqual_it_backend.Services.Device;
using hightqual_it_backend.Services.Motherboard;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Product;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/search")]
public class SearchController : ControllerBase
{
    private ConnectorService _connectService;
    private CpuService _cpuService;
    private GCardService _gCardService;
    private HDiskService _hDiskService;
    private MemoryService _memoryService;
    private OsService _osService;
    private PowerSupplyService _powerService;
    private ScreenService _screenService;
    private SoundService _soundService;
    private MouseService _mouseService;
    

    public SearchController(ConnectorService connector, CpuService cpu, GCardService gcard, HDiskService hdisk,
        MemoryService memory, OsService os, PowerSupplyService power, ScreenService screen, SoundService sound, MouseService mouse)
    {
        _connectService = connector;
        _cpuService = cpu;
        _gCardService = gcard;
        _hDiskService = hdisk;
        _memoryService = memory;
        _osService = os;
        _powerService = power;
        _screenService = screen;
        _soundService = sound;
        _mouseService = mouse;
    }

    [HttpGet("{search}")]
    public IActionResult GetSearch(string search)
    {
        var connectors = _connectService.GetConnectorByNames(search);
        var cpus = _cpuService.GetCpuByNames(search);
        var gcard = _gCardService.GetGraphicProductByNames(search);
        /*var hdisk = _hDiskService.GetHardDiskById(3);*/ // TODO - A faire via un nom
        var memory = _memoryService.GetMemoryByModels(search);
        var mouse = _mouseService.GetMouseByNames(search);
        var os = _osService.GetOsByName(search);
        var power = _powerService.GetPowerByPowers(search);
        var screen = _screenService.GetScreenByName(search);
        /*var sound = _soundService.GetSoundById(3);*/ // TODO - A faire via un nom

        return new JsonResult(new
        {
            connectors = connectors, cpus = cpus, gcard = gcard, memory = memory,
            mouse = mouse, os = os, power = power, screen = screen
        });
    }
}
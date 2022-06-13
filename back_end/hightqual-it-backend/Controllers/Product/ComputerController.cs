using hightqual_it_backend.Services;
using Microsoft.AspNetCore.Cors;

using Microsoft.AspNetCore.Mvc;

using hightqual_it_backend.Tools;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;
using hightqual_it_backend.Dtos;

using Microsoft.EntityFrameworkCore;
using hightqual_it_backend.Models.Logistic;
using System.Collections.Generic;
using hightqual_it_backend.Repositories;


namespace hightqual_it_backend.Controllers;



[EnableCors("allConnections")]
[Route("qual_it/api/v1/computer")]
[ApiController]
public class ComputerController : ControllerBase
{
    private ComputerService _computerService;

    public ComputerController(ComputerService computerService)
    {

        _computerService = computerService;
    }
    

    //private IRepository<Computer> _computerRepo;
    //public ComputerController(ComputerService computerService, IRepository<Computer> computerRepo)
    //{
    //    _computerService = computerService;
    //    _computerRepo = computerRepo;
    //}

    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_computerService.GetComputer());
    }
    
    [HttpGet("{reference}")]
    public IActionResult Get(string reference)
    {
        var computerDto = _computerService.FindByRef(reference);
        decimal average = _computerService.AvgByRef(reference);
        if (computerDto != null)
            return Ok(new { computer = computerDto, average = average });
        return NotFound(new { Message = "Réfèrence non trouvée" });
    }

    //[HttpGet("{reference}")]
    //public IActionResult GetAvg(string reference)
    //{
    //    decimal average = _computerService.AvgByRef(reference);
    //    return Ok(average);
    //}

    [HttpPost]
    [Route("byCateg")]
    public IActionResult GetByCategory([FromForm] string SearchCateg)
    {
        //List<ComputerDto> allComputer = (List<ComputerDto>)_computerService.GetAll();
        var computers = _computerService.GetComputer();
        List<ComputerDto> computersListForCateg = new List<ComputerDto>();
        foreach (ComputerDto c in computers)
        {
            //if(c.Category.Name == SearchCateg.Name)
            if (c.Category.Name == SearchCateg)
            {
                computersListForCateg.Add(c);
            }
        }
        return Ok(computersListForCateg);
    }
}


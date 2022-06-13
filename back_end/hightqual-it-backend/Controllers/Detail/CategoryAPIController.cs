using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Services.Detail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Detail;

[EnableCors("allConnections")]
[Route("qual_it/api/v1/categories")]
public class CategoryAPIController : ControllerBase
{
    private CategoryService _categService;

    public CategoryAPIController(CategoryService categoryService)
    {
        _categService = categoryService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var categories = _categService.GetCategories();
        return Ok(categories);
    }
}
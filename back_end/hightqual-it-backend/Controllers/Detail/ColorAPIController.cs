using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using hightqual_it_backend.Services.Detail;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Controllers.Detail
{
    [EnableCors("allConnections")]
    [Route("qual_it/api/v1/color")]
    [ApiController]
    public class ColorAPIController : ControllerBase
    {
        private ColorService _colorService;
        private ImageService _imageService;

        public ColorAPIController(ColorService colorService, ImageService imageService)
        {
            _colorService = colorService;
            _imageService = imageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var colorDto = _colorService.GetColors();
            return Ok(colorDto);
        }

        [HttpPost]
        public IActionResult PostColor([FromForm] ColorDto colorDto, [FromForm] string Sample)
        {
            ImageDto imgDto = _colorService.FindImage(Sample);
            ColorDto color = new ColorDto()
            {
                Name = colorDto.Name,
                Sample = imgDto,
            };
            _colorService.AddColor(color);
            return StatusCode(201, color);
        }
    }
}

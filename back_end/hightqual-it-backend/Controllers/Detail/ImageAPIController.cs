using hightqual_it_backend.Services.Detail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Detail
{
    [EnableCors("allConnections")]
    [Route("qual_it/api/v1/image")]
    [ApiController]
    public class ImageAPIController : Controller
    {
        private ImageService _imageService;

        public ImageAPIController(ImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var imageDto = _imageService.GetImages();
            return Ok(imageDto);
        }
    }
}

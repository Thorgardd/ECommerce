using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Services.Detail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace hightqual_it_backend.Controllers
{
    [EnableCors("allConnections")]
    [Route("qual_it/api/v1/brand")]
    [ApiController]
    public class BrandAPIController : ControllerBase
    {
        private BrandService _brandService;

        public BrandAPIController(BrandService brandService)
        {
            this._brandService = brandService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var brandsDto = _brandService.GetBrands();
            return Ok(brandsDto);
        }

        [HttpPost]
        public IActionResult PostBrand([FromForm] BrandDto brandDto)
        {
            _brandService.AddBrand(brandDto);
            return StatusCode(201, brandDto);
        }
    }
}

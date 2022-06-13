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
    [Route("qual_it/api/v1/commentary")]
    [ApiController]
    public class CommentaryAPIController : ControllerBase
    {
        private CommentaryService _commentaryService;

        public CommentaryAPIController(CommentaryService commentaryService)
        {
            _commentaryService = commentaryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var commentariesDto = _commentaryService.GetCommentaries();
            return Ok(commentariesDto);
        }

        [HttpPost]
        public IActionResult PostCommentary([FromForm] CommentaryDto commentaryDto)
        {
            _commentaryService.AddCommentary(commentaryDto);
            return StatusCode(201, commentaryDto);
        }
    }
}

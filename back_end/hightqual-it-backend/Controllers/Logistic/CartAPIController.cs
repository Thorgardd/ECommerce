using hightqual_it_backend.Dtos;
using hightqual_it_backend.Services.Logistic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace hightqual_it_backend.Controllers.Logistic
{
    [EnableCors("allConnections")]
    [Route("qual_it/api/v1/cart")]
    [ApiController]
    public class CartAPIController : ControllerBase
    {
        private CartService _cartService;
        public CartAPIController(CartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet, Route("get/{reference}")]
        public IActionResult GetByRef(string reference)
        {
            var actualCart = _cartService.GetByReference(reference);
            return Ok(actualCart);
        }

        [HttpPost, Route("add/{reference}")]
        public IActionResult AddToCart(string reference)
        {
            _cartService.AddToCart(reference);
            return StatusCode(201, reference);
        }

        [HttpDelete, Route("remove/{reference}")]
        public IActionResult RemoveFromCart(string reference)
        {
            _cartService.RemoveFromCart(reference);
            return StatusCode(201, reference);
        }

        [HttpDelete, Route("empty")]
        public IActionResult EmptyTheCart()
        {
            _cartService.EmptyTheCart();
            return Ok("Emptied cart");
        }

    }
}

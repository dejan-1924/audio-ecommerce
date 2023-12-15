using audio_ecommerce.Models.DTOs.Cart;
using audio_ecommerce.Services;
using IIS_Projekat.SupportClasses.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            this._cartService = cartService;
        }

        [HttpPost(Name = "GetCart")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<IEnumerable<CartDTO>> GetCart()
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            var cart = _cartService.GetCart(id);
            return Ok(cart);
        }


        [HttpPost("addItem", Name = "AddItem")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<int> Create([FromBody] int productId)
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            bool isAdded = _cartService.AddItemToCart(productId, id);
            return Ok(isAdded);
        }

    }
}

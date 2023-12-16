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

        [HttpGet(Name = "GetCart")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<CartDTO> GetCart()
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            var cart = _cartService.GetCart(id);
            return Ok(cart);
        }
        [HttpGet("numberOfItems", Name = "GetNumberOfItemsInCart")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<int> GetNumberOfItemsInCart()
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            var cartItems = _cartService.GetCart(id).Items.Count();
            return Ok(cartItems);
        }

        [HttpPost("addItem", Name = "AddItem")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<CartDTO> AddItem([FromBody] AddToCartItemDTO addToCartItem)
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            var newCart = _cartService.AddItemToCart(addToCartItem.Id, addToCartItem.Amount, addToCartItem.isReplace, id);
            return Ok(newCart);
        }
        [HttpDelete("deleteItem/{productId}", Name = "DeleteItem")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<CartDTO> RemoveItemFromCart(int productId)
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            var newCart = _cartService.RemoveItemFromCart(productId, id);
            return Ok(newCart);
        }
    }
}

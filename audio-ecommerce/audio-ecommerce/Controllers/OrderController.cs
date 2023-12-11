using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Services;
using IIS_Projekat.SupportClasses.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpPost("create", Name = "CreateOrder")]
        [AllowAnonymous]
        public ActionResult<int> Create([FromBody] List<ProductCartDTO> products)
        {

            int id = 0;
            bool res = Int32.TryParse(User.GetId(), out id);

            int orderId = _orderService.Create(products, id);
            return Ok(orderId);
        }

    }
}

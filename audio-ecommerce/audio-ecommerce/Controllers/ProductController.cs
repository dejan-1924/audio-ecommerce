using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpPost(Name = "GetAllProducts")]
        public ActionResult<IEnumerable<ProductPreviewDTO>> GetAll([FromBody] ProductFilterQuery query)
        {
            var products = _productService.GetAll(query);

            return Ok(products);
        }


    }
}

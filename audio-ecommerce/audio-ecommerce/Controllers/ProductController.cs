using audio_ecommerce.Models.DTOs.Product;
using audio_ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        public ActionResult<IEnumerable<ProductPreviewDTO>> GetAll([FromBody] ProductFilterQuery query)
        {
            var products = _productService.GetAll(query);

            return Ok(products);
        }

        [HttpGet("{id}", Name = "GetProduct")]
        [AllowAnonymous]
        public ActionResult<ProductDTO> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);

            return Ok(product);
        }


        [HttpDelete("{id}", Name = "DeleteProduct")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok();
        }

    }
}

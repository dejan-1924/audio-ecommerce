using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Pagination;
using audio_ecommerce.Models.DTOs.Product;

namespace audio_ecommerce.Services
{
    public interface IProductService
    {

        PaginationWrapper<ProductPreviewDTO> GetAll(ProductFilterQuery query);
        Product GetProductById(int productId);
        void Delete(int productId);
    }
}

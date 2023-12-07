using audio_ecommerce.Models.DTOs.Product;

namespace audio_ecommerce.Services
{
    public interface IOrderService
    {
        int Create(List<ProductCartDTO> items, int id);
    }
}

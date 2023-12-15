using audio_ecommerce.Models.DTOs.Cart;

namespace audio_ecommerce.Services
{
    public interface ICartService
    {


        bool AddItemToCart(int productId, int quantity, int userId);

        bool RemoveItemFromCart(int productId, int userId);

        CartDTO GetCart(int userId);



    }
}

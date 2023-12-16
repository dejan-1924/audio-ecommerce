using audio_ecommerce.Models.DTOs.Cart;

namespace audio_ecommerce.Services
{
    public interface ICartService
    {


        CartDTO AddItemToCart(int productId, int quantity, bool isReplace, int userId);

        CartDTO RemoveItemFromCart(int productId, int userId);

        CartDTO GetCart(int userId);



    }
}

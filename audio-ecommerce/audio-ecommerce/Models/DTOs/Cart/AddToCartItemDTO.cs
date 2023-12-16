namespace audio_ecommerce.Models.DTOs.Cart
{
    public class AddToCartItemDTO
    {

        public int Id { get; set; }
        public int Amount { get; set; }

        public bool isReplace { get; set; }
    }
}

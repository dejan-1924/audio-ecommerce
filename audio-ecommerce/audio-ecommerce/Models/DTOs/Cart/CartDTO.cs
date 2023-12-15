namespace audio_ecommerce.Models.DTOs.Cart
{
    public class CartDTO
    {
        public IEnumerable<CartItemDTO> Items { get; set; }

        public double Total { get; set; }

        public CartDTO(IEnumerable<CartItemDTO> items, double total)
        {
            Items = items;
            Total = total;
        }
    }
}

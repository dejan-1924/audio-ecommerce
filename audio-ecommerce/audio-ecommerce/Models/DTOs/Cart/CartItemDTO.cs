namespace audio_ecommerce.Models.DTOs.Cart
{
    public class CartItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public int Amount { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public int InStock { get; set; }

        public CartItemDTO(int id, string name, string artistName, int amount, double price, string imageUrl, int inStock)
        {
            Id = id;
            Name = name;
            ArtistName = artistName;
            Amount = amount;
            Price = price;
            ImageUrl = imageUrl;
            InStock = inStock;
        }
    }
}

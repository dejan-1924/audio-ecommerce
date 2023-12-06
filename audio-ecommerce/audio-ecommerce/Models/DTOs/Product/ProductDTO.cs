namespace audio_ecommerce.Models.DTOs.Product
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }

        public string ArtistId { get; set; }
        public string Label { get; set; }
        public string Format { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}

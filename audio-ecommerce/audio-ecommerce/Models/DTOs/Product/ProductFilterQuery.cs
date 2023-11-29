namespace audio_ecommerce.Models.DTOs.Product
{
    public class ProductFilterQuery
    {
        public bool IsOrderAscending { get; set; }
        public string SearchQuery { get; set; }
        public int ArtistId { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}

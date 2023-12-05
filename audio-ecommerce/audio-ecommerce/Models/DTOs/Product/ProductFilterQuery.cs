namespace audio_ecommerce.Models.DTOs.Product
{
    public class ProductFilterQuery
    {
        public string SearchQuery { get; set; }
        public ICollection<int> ArtistIds { get; set; }

        public ICollection<int> FormatIds { get; set; }

        public ICollection<int> LabelIds { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string Ordering { get; set; }
    }
}

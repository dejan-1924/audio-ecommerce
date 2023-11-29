namespace audio_ecommerce.Models.DTOs.Pagination
{
    public class PaginationWrapper<T>
    {
        public IEnumerable<T> Entities { get; set; }
        public int TotalCount { get; set; }
    }
}

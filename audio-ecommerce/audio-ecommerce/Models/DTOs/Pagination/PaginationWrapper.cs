using audio_ecommerce.Models.DTOs.Artist;

namespace audio_ecommerce.Models.DTOs.Pagination
{
    public class PaginationWrapper<T>
    {
        public IEnumerable<T> Entities { get; set; }
        public int TotalCount { get; set; }

        public IEnumerable<ArtistCountDTO> Artists { get; set; }

        public IEnumerable<ArtistCountDTO> Labels { get; set; }
        public IEnumerable<ArtistCountDTO> Formats { get; set; }
    }
}

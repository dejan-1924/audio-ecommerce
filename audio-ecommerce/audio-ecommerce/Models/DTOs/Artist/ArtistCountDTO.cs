namespace audio_ecommerce.Models.DTOs.Artist
{
    public class ArtistCountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Count { get; set; }

        public ArtistCountDTO(int id, string name, int count)
        {
            Id = id;
            Name = name;
            Count = count;
        }
    }
}

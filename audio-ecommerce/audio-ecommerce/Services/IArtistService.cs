using audio_ecommerce.Models.DTOs.Artist;

namespace audio_ecommerce.Services
{
    public interface IArtistService
    {

        int CreateArtist(string name);

        IEnumerable<ArtistDTO> GetAll();


    }
}

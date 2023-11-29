namespace audio_ecommerce.SupportClasses.AutoMapper;
using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Artist;
using global::AutoMapper;

public class ArtistProfile : Profile
{
    public ArtistProfile()
    {
        CreateMap<Artist, ArtistDTO>();

    }
}


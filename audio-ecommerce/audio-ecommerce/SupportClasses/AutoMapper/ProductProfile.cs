namespace audio_ecommerce.SupportClasses.AutoMapper;
using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Product;
using global::AutoMapper;

public class ProductProfile : Profile
{

    public ProductProfile()
    {
        CreateMap<Product, ProductPreviewDTO>().ForMember(p => p.ArtistName, opt => opt.MapFrom(src => src.Artist.Name));
        CreateMap<Product, ProductDTO>()
            .ForMember(p => p.ArtistName, opt => opt.MapFrom(src => src.Artist.Name))
            .ForMember(p => p.Label, opt => opt.MapFrom(src => src.Label.Name))
            .ForMember(p => p.Format, opt => opt.MapFrom(src => src.Format.Name)
        );
    }
}


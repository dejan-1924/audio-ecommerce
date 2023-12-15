using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Cart;
using AutoMapper;

namespace audio_ecommerce.SupportClasses.AutoMapper
{
    public class CartProfile : Profile
    {

        public CartProfile()
        {
            CreateMap<Cart, CartDTO>().ForMember(p => p.Items, opt => opt.MapFrom(src => src.CartItems));
            CreateMap<CartItem, CartItemDTO>()
                .ForMember(p => p.ArtistName, opt => opt.MapFrom(src => src.Product.Artist.Name))
                .ForMember(p => p.Name, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(p => p.Price, opt => opt.MapFrom(src => src.Product.Price))
                .ForMember(p => p.ImageUrl, opt => opt.MapFrom(src => src.Product.ImageUrl))
                .ForMember(p => p.InStock, opt => opt.MapFrom(src => src.Product.Price));
        }

    }
}
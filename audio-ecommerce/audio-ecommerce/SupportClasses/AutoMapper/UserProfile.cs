using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.User;
using AutoMapper;

namespace audio_ecommerce.SupportClasses.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<NewUserDTO, User>();
            CreateMap<User, UserDTO>();
        }


    }
}

using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Address;
using AutoMapper;

namespace audio_ecommerce.SupportClasses.AutoMapper
{
    public class AddressProfile : Profile
    {

        public AddressProfile()
        {
            CreateMap<Address, AddressDTO>();
        }

    }
}

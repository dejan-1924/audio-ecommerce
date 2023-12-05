using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Label;
using AutoMapper;

namespace audio_ecommerce.SupportClasses.AutoMapper
{
    public class LabelProfile : Profile
    {

        public LabelProfile()
        {
            CreateMap<Label, LabelDTO>();
        }

    }
}

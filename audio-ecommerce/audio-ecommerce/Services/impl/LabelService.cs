using audio_ecommerce.Models.DTOs.Label;
using audio_ecommerce.Repositories;
using AutoMapper;

namespace audio_ecommerce.Services.impl
{
    public class LabelService : ILabelService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LabelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }


        public IEnumerable<LabelDTO> GetAll()
        {

            return _mapper.Map<IEnumerable<LabelDTO>>(_unitOfWork.LabelRepository.GetAll());

        }


    }

}

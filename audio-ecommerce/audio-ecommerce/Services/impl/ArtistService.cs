using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.Artist;
using audio_ecommerce.Repositories;
using AutoMapper;

namespace audio_ecommerce.Services.impl
{
    public class ArtistService : IArtistService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArtistService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public int CreateArtist(string name)
        {
            var existingArtist = _unitOfWork.ArtistRepository.GetAll().FirstOrDefault(e => e.Name == name); ;

            if (existingArtist != null)
            {
                throw new InvalidOperationException($"An artist with the name '{name}' already exists.");
            }
            Artist artist = new Artist(name);
            _unitOfWork.ArtistRepository.Create(artist);
            _unitOfWork.SaveChanges();
            return artist.Id;
        }


        public IEnumerable<ArtistDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<ArtistDTO>>(_unitOfWork.ArtistRepository.GetAll());


        }



    }
}

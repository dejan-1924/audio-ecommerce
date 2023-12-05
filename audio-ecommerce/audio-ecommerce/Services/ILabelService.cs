using audio_ecommerce.Models.DTOs.Label;

namespace audio_ecommerce.Services
{
    public interface ILabelService
    {
        IEnumerable<LabelDTO> GetAll();
    }
}

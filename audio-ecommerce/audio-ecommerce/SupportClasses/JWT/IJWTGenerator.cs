using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.User;

namespace audio_ecommerce.SupportClasses.JWT
{
    public interface IJWTGenerator
    {
        JWTokenWrapper GenerateToken(User user);
    }
}

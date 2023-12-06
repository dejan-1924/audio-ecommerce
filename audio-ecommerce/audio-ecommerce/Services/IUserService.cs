using audio_ecommerce.Models.DTOs.User;

namespace audio_ecommerce.Services
{
    public interface IUserService
    {
        int Register(NewUserDTO newUser);
        JWTokenWrapper Login(LoginDTO credentials);

        UserDTO GetById(int id);
    }
}

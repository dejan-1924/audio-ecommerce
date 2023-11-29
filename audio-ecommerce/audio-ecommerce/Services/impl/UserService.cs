using audio_ecommerce.Models;
using audio_ecommerce.Models.DTOs.User;
using audio_ecommerce.Repositories;
using audio_ecommerce.SupportClasses.JWT;
using AutoMapper;
using FBSApp.SupportClasses.PasswordHasher;

namespace audio_ecommerce.Services.impl
{
    public class UserService : IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJWTGenerator _jwtGenerator;


        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IJWTGenerator jwtGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtGenerator = jwtGenerator;
        }

        public int Register(NewUserDTO newUser)
        {
            if (_unitOfWork.UserRepository.GetAll().Where(u => u.Email == newUser.Email).Any())
            {
                throw new InvalidOperationException($"There is already user in database with email: {newUser.Email}.");
            }
            byte[] salt;
            var user = _mapper.Map<User>(newUser);
            user.Password = PasswordHasher.HashPassword(newUser.Password, out salt);
            user.Salt = salt;
            user.Role = "USER";
            var createdUser = _unitOfWork.UserRepository.Create(user);

            _unitOfWork.SaveChanges();

            return createdUser.Id;
        }


        public JWTokenWrapper Login(LoginDTO credentials)
        {
            var user = _unitOfWork.UserRepository.GetAll().FirstOrDefault(u => u.Email == credentials.Email);
            if (user == null)
            {
                throw new InvalidOperationException($"There is not user in database with email: {credentials.Email}.");
            }
            if (!PasswordHasher.VerifyPassword(credentials.Password, user.Password, user.Salt))
            {
                throw new InvalidOperationException();
            }
            return _jwtGenerator.GenerateToken(user);
        }
    }
}

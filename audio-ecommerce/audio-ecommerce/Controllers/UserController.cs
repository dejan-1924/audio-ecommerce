using audio_ecommerce.Models.DTOs.User;
using audio_ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register", Name = "Register")]
        [AllowAnonymous]
        public ActionResult<long> Register([FromBody] NewUserDTO newUser)
        {
            return Ok(_userService.Register(newUser));
        }


        [HttpPost("login", Name = "Login")]
        [AllowAnonymous]
        public ActionResult<JWTokenWrapper> Login([FromBody] LoginDTO credentials)
        {
            return Ok(_userService.Login(credentials));
        }


        [HttpGet("{id}", Name = "GetUser")]
        [AllowAnonymous]
        public ActionResult<UserDTO> GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

    }
}

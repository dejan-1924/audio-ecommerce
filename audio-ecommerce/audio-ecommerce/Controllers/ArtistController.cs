using audio_ecommerce.Models.DTOs.Artist;
using audio_ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {

        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            this._artistService = artistService;
        }

        [HttpPost(Name = "GetAllArtists")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<ArtistDTO>> GetAll()
        {
            var authors = _artistService.GetAll();

            return Ok(authors);
        }


        [HttpPost("add", Name = "AddArtist")]
        [Authorize(Roles = "ADMIN")]
        public ActionResult<int> AddArtist([FromBody] string name)
        {

            Console.WriteLine(name);
            long createdBookId = _artistService.CreateArtist(name);

            return Ok(createdBookId);
        }
    }
}

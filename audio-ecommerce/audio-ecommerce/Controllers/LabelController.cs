using audio_ecommerce.Models.DTOs.Label;
using audio_ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audio_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {

        private readonly ILabelService _labelService;

        public LabelController(ILabelService labelService)
        {
            this._labelService = labelService;
        }

        [HttpGet(Name = "GetAllLabels")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<LabelDTO>> GetAll()
        {
            var labels = _labelService.GetAll();

            return Ok(labels);
        }

    }
}

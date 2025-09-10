using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebRand.Services;

namespace WebRand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RanController : ControllerBase
    {
        private readonly RollService _rollService;
        public RanController(RollService rollService)
        {
            _rollService = rollService;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] int? min, [FromQuery] int? max)
        {
            int actualMin = min ?? 0;                
            int actualMax = max ?? int.MaxValue;
            var rolled = _rollService.Roll(actualMin, actualMax);

            return Ok(new { min = actualMin, max = actualMax, rolled });
        }

    }
}

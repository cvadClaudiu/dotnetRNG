using Microsoft.AspNetCore.Mvc;
using WebRand.Services;
using WebRand.Infrastructure;

namespace WebRand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        private readonly DRollService _drollservice;
        public DiceController(DRollService drollservice)
        {
            _drollservice = drollservice;
        }

        [HttpGet("roll")]
        public IActionResult DRollDice(DiceType type = DiceType.d6, int amount = 1)
        {
            var dice = new Dice(type, amount);
            var results = _drollservice.Droll(dice);

            return Ok(new { type = type.ToString(), amount, results });
        }
    }
}

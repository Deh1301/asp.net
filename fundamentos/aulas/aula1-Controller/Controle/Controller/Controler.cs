using Microsoft.AspNetCore.Mvc;

namespace Controle.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
    }
}
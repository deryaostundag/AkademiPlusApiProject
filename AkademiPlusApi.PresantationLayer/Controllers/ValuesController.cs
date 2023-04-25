using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusApi.PresantationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Deneme()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}

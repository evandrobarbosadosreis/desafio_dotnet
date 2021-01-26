using CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalcularJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult Get()
        {
            var URLGithub = Github.BuscarURLDoRepositorio();

            return Ok(URLGithub);
        }
    }
}
using CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalcularJuros.Controllers
{
    [Route("api/v1/[controller]")]
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
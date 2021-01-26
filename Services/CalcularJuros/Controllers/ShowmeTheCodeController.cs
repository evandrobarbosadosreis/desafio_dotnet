using CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalcularJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowmeTheCodeController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult GetURL()
        {
            var resultado = GithubService.BuscarURL();
            return Ok(resultado);
        }
    }
}
using Desafio.CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.CalcularJuros.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
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
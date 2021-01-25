using Desafio.CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.CalcularJuros.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult GetCalculoJuros(decimal valorInicial, int meses)
        {
            var taxaJuros = 0.01; //TODO buscar da outra api
            var resultado = CalculaJurosService.CalcularJuros(valorInicial, taxaJuros, meses);
            return Ok(resultado);
        }
    }
}
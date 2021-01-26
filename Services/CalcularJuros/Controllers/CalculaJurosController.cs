using CalcularJuros.Services;
using CalcularJuros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalcularJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IConsultaTaxaDeJurosHttpService _http;

        public CalculaJurosController(IConsultaTaxaDeJurosHttpService http)
        {
            _http = http;
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult> GetCalculoJuros(decimal valorInicial, int meses)
        {
            var taxaJuros = await _http.ConsultarTaxaDeJurosPorHTTP();

            if (taxaJuros <= 0)
            {
                return BadRequest();
            }

            var resultado = CalculaJurosService.CalcularJuros(valorInicial, taxaJuros, meses);

            return Ok(resultado);
        }
    }
}
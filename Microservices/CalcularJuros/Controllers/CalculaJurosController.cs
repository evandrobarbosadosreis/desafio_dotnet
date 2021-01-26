using CalcularJuros.Services;
using CalcularJuros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalcularJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {

        private readonly IConsultaTaxaDeJurosPorHTTP _consultaTaxa;
        private readonly CalculadoraDeJuros _calculadora;

        public CalculaJurosController(IConsultaTaxaDeJurosPorHTTP consultaTaxa)
        {
            _consultaTaxa = consultaTaxa;
            _calculadora = new CalculadoraDeJuros();
        }

        [Route("")]
        [HttpGet]
        public async Task<ActionResult> Get(decimal valorInicial, int meses)
        {
            var taxaJuros = await _consultaTaxa.ExecutarConsultaHTTP();

            if (taxaJuros <= 0)
            {
                return BadRequest("Não foi possível buscar a taxa de juros atual");
            }

            var resultado = _calculadora.CalcularRendimento(valorInicial, taxaJuros, meses);

            return Ok(resultado);
        }
    }
}
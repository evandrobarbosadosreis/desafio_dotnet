using Desafio.RetornarJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.RetornarJuros.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class JurosController : ControllerBase
    {
        [Route("taxaJuros")]
        public ActionResult GetTaxaJuros()
        {
            var taxaAtual = TaxaJurosService.BuscarTaxaJurosAtual();
            return Ok(taxaAtual);
        }
    }
}

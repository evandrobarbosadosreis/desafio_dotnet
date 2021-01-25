using Desafio.RetornarJuros.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.RetornarJuros.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult GetTaxaJuros()
        {
            var taxaAtual = TaxaJurosService.BuscarTaxaJurosAtual();
            return Ok(taxaAtual);
        }
    }
}

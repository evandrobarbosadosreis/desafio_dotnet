using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Services;

namespace TaxaJuros.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult Get()
        {
            var taxaAtual = TaxaDeJuros.BuscarTaxaDeJurosAtual();

            return Ok(taxaAtual);
        }
    }
}
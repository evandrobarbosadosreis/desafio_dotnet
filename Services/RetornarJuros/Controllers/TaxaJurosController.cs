using Microsoft.AspNetCore.Mvc;
using RetornarJuros.Services;

namespace RetornarJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
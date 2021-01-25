using Desafio.RetornarJuros.Controllers;
using Desafio.RetornarJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Desafio.RetornarJuros.Testes.Controllers
{
    public class TaxaJurosControllerTeste
    {
        [Fact]
        public void DeveBuscarTaxaDeJuros()
        {
            //Given
            var controller = new TaxaJurosController();
            var taxaEsperada = TaxaJurosService.BuscarTaxaJurosAtual();

            //When
            ActionResult<double> resposta = controller.GetTaxaJuros();

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(taxaEsperada, ok.Value);
        }
    }
}
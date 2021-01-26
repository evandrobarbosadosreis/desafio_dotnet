using TaxaJuros.Controllers;
using TaxaJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace TaxaJuros.Testes.Controllers
{
    public class TaxaJurosControllerTeste
    {
        [Fact]
        public void DeveBuscarATaxaDeJurosAtual()
        {
            //Given
            var controller = new TaxaJurosController();
            var taxaEsperada = TaxaDeJuros.BuscarTaxaDeJurosAtual();

            //When
            ActionResult<double> resposta = controller.Get();

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(taxaEsperada, ok.Value);
        }
    }
}
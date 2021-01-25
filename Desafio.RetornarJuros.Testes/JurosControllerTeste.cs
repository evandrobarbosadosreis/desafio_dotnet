using Desafio.RetornarJuros.Controllers;
using Desafio.RetornarJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Desafio.RetornarJuros.Testes
{
    public class JurosControllerTeste
    {
        [Fact]
        public void DeveBuscarTaxaDeJuros()
        {
            //Given
            var controller = new JurosController();
            var taxaEsperada = TaxaJurosService.BuscarTaxaJurosAtual();

            //When
            ActionResult<decimal> resposta = controller.Get();

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(taxaEsperada, ok.Value);
        }
    }
}
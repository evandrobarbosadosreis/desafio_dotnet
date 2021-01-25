using Desafio.CalcularJuros.Controllers;
using Desafio.CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Desafio.CalcularJuros.Testes.Controllers
{
    public class CalculaJurosControllerTeste
    {
        [Fact]
        public void DeveRetornarCalculoDeJuros()
        {
            //Given
            var controller = new CalculaJurosController();
            var valorInicial = 100m;
            var periodoEmMeses = 5;
            var valorEsperado = CalculaJurosService.CalcularJuros(valorInicial, 0.01, 5);

            //When
            ActionResult<string> resposta = controller.GetCalculoJuros(valorInicial, periodoEmMeses);

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(valorEsperado, ok.Value);
        }
    }
}
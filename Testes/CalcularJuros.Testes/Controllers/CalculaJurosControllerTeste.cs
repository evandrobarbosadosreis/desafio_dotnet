using System.Threading.Tasks;
using CalcularJuros.Controllers;
using CalcularJuros.Services;
using CalcularJuros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace CalcularJuros.Testes.Controllers
{
    public class CalculaJurosControllerTeste
    {
        [Fact]
        public async Task DeveRetornarCalculoDeJuros()
        {
            //Given
            var taxaDeJuros = 0.01;
            var valorInicial = 100m;
            var periodoEmMeses = 5;
            var mock = new Mock<IConsultaTaxaDeJurosHttpService>();
            mock.Setup(i => i.ConsultarTaxaDeJurosPorHTTP()).ReturnsAsync(taxaDeJuros);
            var controller = new CalculaJurosController(mock.Object);
            var valorEsperado = CalculaJurosService.CalcularJuros(valorInicial, taxaDeJuros, periodoEmMeses);

            //When
            ActionResult<string> resposta = await controller.GetCalculoJuros(valorInicial, periodoEmMeses);

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(valorEsperado, ok.Value);
        }
    }
}
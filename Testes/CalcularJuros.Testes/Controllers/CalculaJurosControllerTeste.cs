using System.Threading.Tasks;
using Moq;
using Xunit;
using CalcularJuros.Controllers;
using CalcularJuros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalcularJuros.Testes.Controllers
{

    public class CalculaJurosControllerTeste
    {

        [Fact]
        public async Task DeveRetornarCalculoDeJuros()
        {
            //Given

            //prepara os valores
            var valorAplicado = 100m;
            var taxaJuros = 0.01;
            var periodoEmMeses = 5;
            var valorFinalEsperado = 105.10m;
            //prepara o mock do serviço de consulta http
            var mockHTTP = new Mock<IConsultaTaxaDeJurosPorHTTP>();
            mockHTTP.Setup(i => i.ExecutarConsultaHTTP()).ReturnsAsync(taxaJuros);
            //cria o controller pra teste
            var controller = new CalculaJurosController(mockHTTP.Object);

            //When
            ActionResult<string> resposta = await controller.Get(valorAplicado, periodoEmMeses);

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(valorFinalEsperado, ok.Value);
        }
    }
}
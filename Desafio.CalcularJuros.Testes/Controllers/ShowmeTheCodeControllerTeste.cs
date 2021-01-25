using Desafio.CalcularJuros.Controllers;
using Desafio.CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Desafio.CalcularJuros.Testes.Controllers
{
    public class ShowmeTheCodeControllerTeste
    {
        [Fact]
        public void DeveRetornarAURLCorreta()
        {
            //Given
            var controller = new ShowmeTheCodeController();
            var urlEsperada = GithubService.BuscarURL();
            
            //When
            ActionResult<string> resposta = controller.GetURL();

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(urlEsperada, ok.Value);
        }
    }
}
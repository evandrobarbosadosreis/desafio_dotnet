using CalcularJuros.Controllers;
using CalcularJuros.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CalcularJuros.Testes.Controllers
{
    public class ShowMeTheCodeControllerTeste
    {
        [Fact]
        public void DeveRetornarAURLCorreta()
        {
            //Given
            var controller = new ShowMeTheCodeController();
            var urlEsperada = Github.BuscarURLDoRepositorio();
            
            //When
            ActionResult<string> resposta = controller.Get();

            //Then
            var ok = Assert.IsType<OkObjectResult>(resposta.Result);
            Assert.Equal(urlEsperada, ok.Value);
        }
    }
}
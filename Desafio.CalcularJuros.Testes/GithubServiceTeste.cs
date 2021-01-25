using Desafio.CalcularJuros.Services;
using Xunit;

namespace Desafio.CalcularJuros.Testes
{
    public class GithubServiceTeste
    {
        [Fact]
        public void NaoDeveRetornarVazio()
        {
            //When
            var url = GithubService.BuscarURL();

            //Then
            Assert.NotEmpty(url);
        }
    }

}
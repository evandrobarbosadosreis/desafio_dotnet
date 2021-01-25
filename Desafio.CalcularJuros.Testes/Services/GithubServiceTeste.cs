using Desafio.CalcularJuros.Services;
using Xunit;

namespace Desafio.CalcularJuros.Testes.Services
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
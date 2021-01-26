using CalcularJuros.Services;
using Xunit;

namespace CalcularJuros.Testes.Services
{
    public class GithubTeste
    {
        [Fact]
        public void NaoDeveRetornarURLVazia()
        {
            //When
            var url = Github.BuscarURLDoRepositorio();

            //Then
            Assert.NotEmpty(url);
        }
    }

}
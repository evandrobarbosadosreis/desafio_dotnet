using Desafio.CalcularJuros.Services;
using Xunit;

namespace Desafio.CalcularJuros.Testes.Services
{
    public class CalculaJurosServiceTeste
    {
        [Fact]
        public void DeveCalcularJurosCorretamente()
        {
            //Given
            var valorAplicado = 100m;
            var taxaJuros = 0.01;
            var periodoEmMeses = 5;
            var valorFinalEsperado = 105.10m;
            
            //When
            var valorFinal = CalculaJurosService.CalcularJuros(
                valorAplicado, 
                taxaJuros, 
                periodoEmMeses);
            
            //Then
            Assert.Equal(valorFinalEsperado, valorFinal);
        }
    }
}
using Desafio.CalcularJuros.Services;
using Xunit;

namespace Desafio.CalcularJuros.Testes
{
    public class CalculadoraJurosServiceTeste
    {
        [Fact]
        public void DeveCalcularJurosCorretamente()
        {
            //Given
            var valorAplicado = 100;
            var taxaJuros = 0.01;
            var periodoEmMeses = 5;
            var valorFinalEsperado = 105.10;
            
            //When
            var valorFinal = CalculadoraJurosService.CalcularJuros(
                valorAplicado, 
                taxaJuros, 
                periodoEmMeses);
            
            //Then
            Assert.Equal(valorFinalEsperado, valorFinal);
        }
    }
}
using CalcularJuros.Services;
using Xunit;

namespace CalcularJuros.Testes.Services
{
    public class CalculadoraDeJurosTeste
    {
        [Fact]
        public void DeveCalcularOsJurosCorretamente()
        {
            //Given
            var calculadora = new CalculadoraDeJuros();
            var valorAplicado = 100m;
            var taxaJuros = 0.01;
            var periodoEmMeses = 5;
            var valorFinalEsperado = 105.10m;
            
            //When
            var valorFinal = calculadora.CalcularRendimento(
                valorAplicado, 
                taxaJuros, 
                periodoEmMeses);
            
            //Then
            Assert.Equal(valorFinalEsperado, valorFinal);
        }
    }
}
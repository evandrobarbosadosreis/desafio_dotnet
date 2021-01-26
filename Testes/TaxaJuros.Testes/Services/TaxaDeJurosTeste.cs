using TaxaJuros.Services;
using Xunit;

namespace TaxaJuros.Testes.Services
{
    public class TaxaDeJurosTeste
    {
        [Fact]
        public void DeveRetornarUmPorCento()
        {
            //Given
            var taxaEsperada = 0.01;

            //When
            var taxa = TaxaDeJuros.BuscarTaxaDeJurosAtual();

            //Then
            Assert.Equal(taxaEsperada, taxa);
        }
    }
}
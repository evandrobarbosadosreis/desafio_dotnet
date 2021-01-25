using Desafio.RetornarJuros.Services;
using Xunit;

namespace Desafio.RetornarJuros.Testes.Services
{
    public class TaxaJurosServiceTeste
    {
        [Fact]
        public void DeveRetornarUmPorCento()
        {
            //Given
            var taxaEsperada = 0.01;

            //When
            var taxa = TaxaJurosService.BuscarTaxaJurosAtual();

            //Then
            Assert.Equal(taxaEsperada, taxa);
        }
    }
}
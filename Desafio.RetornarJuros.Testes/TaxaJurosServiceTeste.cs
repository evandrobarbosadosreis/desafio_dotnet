using Desafio.RetornarJuros.Services;
using Xunit;

namespace Desafio.RetornarJuros.Testes
{
    public class TaxaJurosServiceTeste
    {
        [Fact]
        public void DeveRetornarUmPorCento()
        {
            //When
            var taxa = TaxaJurosService.BuscarTaxaJurosAtual();
            
            //Then
            Assert.Equal(0.01m, taxa);
        }
    }
}
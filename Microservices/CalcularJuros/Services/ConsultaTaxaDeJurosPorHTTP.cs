using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CalcularJuros.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CalcularJuros.Services
{
    public class ConsultaTaxaDeJurosPorHTTP : IConsultaTaxaDeJurosPorHTTP
    {
        private readonly IConfiguration Configuration;

        public string URL => Configuration.GetSection("URLs").GetSection("TaxaJurosAPI").Value;

        public ConsultaTaxaDeJurosPorHTTP(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private async Task<double> ObterTaxaDoCorpoDaResposta(HttpResponseMessage respostaHTTP)
        {
            //pega o corpo
            var body = await respostaHTTP.Content.ReadAsStringAsync();
            //tenta extrair o valor
            var sucesso = double.TryParse(body, NumberStyles.Any, CultureInfo.InvariantCulture, out var taxaJuros);
            //determina o resultado
            return sucesso ? taxaJuros : 0;
        }

        public async Task<double> ExecutarConsultaHTTP()
        {
            //Não tenho experiência em microsserviços, portanto, tenho lá 
            //minhas dúvidas se uma requisição HTTP no gateway é a melhor
            //maneira de estabelecer uma comunicação entre os componentes
            using (var http = new HttpClient())
            {
                var respostaHTTP = await http.GetAsync(URL);

                if (respostaHTTP.StatusCode == HttpStatusCode.OK)
                {
                    return await ObterTaxaDoCorpoDaResposta(respostaHTTP);
                }
            }
            return 0;
        }
    }
}

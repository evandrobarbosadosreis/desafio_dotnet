using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CalcularJuros.Services.Interfaces;

namespace CalcularJuros.Services
{
    public class ConsultaTaxaDeJurosHttpService : IConsultaTaxaDeJurosHttpService
    {
        //URL do Gateway
        private const string URL = "http://localhost:5000/api/taxajuros";

        public async Task<double> ConsultarTaxaDeJurosPorHTTP()
        {
            using (var http = new HttpClient())
            {
                var respostaHttp = await http.GetAsync(URL);

                if (respostaHttp.StatusCode == HttpStatusCode.OK)
                {
                    var body = await respostaHttp.Content.ReadAsStringAsync();

                    if (double.TryParse(body, NumberStyles.Any, CultureInfo.InvariantCulture, out var taxaJuros))
                    {
                        return taxaJuros;
                    }
                }
                return 0;
            }
        }
    }
}
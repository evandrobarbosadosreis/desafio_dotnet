using System.Threading.Tasks;

namespace CalcularJuros.Services.Interfaces
{
    public interface IConsultaTaxaDeJurosHttpService
    {
        Task<double> ConsultarTaxaDeJurosPorHTTP();
    }

}
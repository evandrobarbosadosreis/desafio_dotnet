using System.Threading.Tasks;

namespace CalcularJuros.Services.Interfaces
{
    public interface IConsultaHTTP<T>
    {
        string URL { get; }
        Task<T> ExecutarConsultaHTTP();
    }

}
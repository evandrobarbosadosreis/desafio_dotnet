using System;

namespace CalcularJuros.Services
{
    public class CalculadoraDeJuros
    {
        private decimal Truncar(decimal valor)
        {
            return Math.Truncate(valor * 100 ) / 100;
        }

        public decimal CalcularRendimento(decimal valorAplicado, double taxaJuros, int periodoEmMeses)
        {
            var resultado = valorAplicado * (decimal) Math.Pow(1 + taxaJuros, periodoEmMeses);

            return Truncar(resultado);
        }
    }
}
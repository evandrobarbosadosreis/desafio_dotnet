using System;

namespace CalcularJuros.Services
{
    public static class CalculaJurosService
    {

        private static decimal Truncar(decimal valor)
        {
            return Math.Truncate(valor * 100 ) / 100;
        }

        public static decimal CalcularJuros(decimal valorAplicado, double taxaJuros, int periodoEmMeses)
        {
            var resultado = valorAplicado * (decimal) Math.Pow(1 + taxaJuros, periodoEmMeses);

            return Truncar(resultado);
        }
    }
}
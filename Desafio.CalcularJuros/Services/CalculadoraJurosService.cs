using System;

namespace Desafio.CalcularJuros.Services
{
    public static class CalculadoraJurosService
    {

        private static double Truncar(double valor)
        {
            return Math.Truncate(valor * 100 ) / 100;
        }

        public static double CalcularJuros(double valorAplicado, double taxaJuros, int periodoEmMeses)
        {
            var resultado = valorAplicado * Math.Pow(1 + taxaJuros, periodoEmMeses);

            return Truncar(resultado);
        }
    }
}
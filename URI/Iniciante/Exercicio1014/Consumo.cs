using System;

namespace URI.Iniciante.Exercicio1014
{
    public class Consumo
    {
        public static double ConsumoMedio(int distancia, double litros)
        {
            return Math.Round(distancia / litros, 3);
        }
    }
}

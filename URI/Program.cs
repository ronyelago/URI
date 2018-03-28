using System;
using URI.Iniciante.Exercicio1014;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consumo médio: {0} km/l", Consumo.ConsumoMedio(500, 35));
            Console.ReadKey();
        }
    }
}

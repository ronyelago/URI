using System;
using URI.Iniciante.Exercicio1010;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda v1 = new Venda { Codigo = 123, Preco = 5.30 };
            Venda v2 = new Venda { Codigo = 456, Preco = 5.10 };

            Console.Write("Quantidade do produto 1: ");
            v1.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Quantidade do produto 2: ");
            v2.Quantidade = int.Parse(Console.ReadLine());

            double total = CalculoSimples.Calcular(v1) + CalculoSimples.Calcular(v2);

            Console.WriteLine("Total da Compra : {0}\n\n", total);
            Console.ReadKey();
        }
    }
}

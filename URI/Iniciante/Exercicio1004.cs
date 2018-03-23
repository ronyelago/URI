using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante
{
    public class Exercicio1004
    {
        public static void Produto()
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int prod = a * b;

            Console.Write("Prod = {0}\n\n", prod);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1001
{
    public class Soma
    {
        public static void SomaSimples()
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine("X = {0}\n", x);
        }
    }
}

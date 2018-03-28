using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1002
{
    class Area
    {
        public static void AreaCirculo(double raio)
        {
            double area = Math.PI * (raio * raio);

            Console.WriteLine("A = {0}\n\n", area);
        }
    }
}

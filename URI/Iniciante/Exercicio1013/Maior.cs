using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1013
{
    public class Maior
    {
        public static int MaiorNumero(int a, int b, int c)
        {
            int maior = (a + b + Math.Abs(a - b)) / 2;
            maior = (maior + c + Math.Abs(maior - c)) / 2;

            return maior;
        }
    }
}

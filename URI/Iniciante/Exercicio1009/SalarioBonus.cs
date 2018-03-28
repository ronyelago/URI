using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1009
{
    class SalarioBonus
    {
        public static double SalarioLiquido(double salario, double vendas)
        {
            return salario + (vendas * 15) / 100;
        }
    }
}

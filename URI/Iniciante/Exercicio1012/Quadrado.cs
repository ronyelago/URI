using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1012
{
    class Quadrado
    {
        public double Lado { get; set; }
        public double Area
        {
            get { return Lado * Lado; }
        }
    }
}

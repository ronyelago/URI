using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1012
{
    class Retangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double Area
        {
            get
            {
                return LadoA * LadoB;
            }
        }
    }
}

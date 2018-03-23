using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1012
{
    class Circulo
    {
        public double Raio { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Raio, 2);
            }
        }
    }
}

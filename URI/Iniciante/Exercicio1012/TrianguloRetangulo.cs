using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1012
{
    public class TrianguloRetangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Area
        {
            get
            {
                if (Base > 0 && Altura > 0)
                {
                    return (Base * Altura) / 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

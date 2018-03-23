using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1012
{
    public class Trapezio
    {
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Area
        {
            get
            {
                return ((BaseMaior + BaseMenor) * Altura) / 2;
            }
        }
    }
}

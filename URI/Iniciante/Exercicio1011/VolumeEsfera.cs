using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante.Exercicio1011
{
    public class VolumeEsfera
    {
        public static double Volume(double raio)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Iniciante
{
    public class Exercicio1006
    {
        public static void MediaPonderada()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();

            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.Write("Digite o valor da nota A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da nota B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da nota C: ");
            double c = double.Parse(Console.ReadLine());

            double media = (a * 2 + b * 3 + c * 5) / 10;

            Console.WriteLine("MEDIA = {0}\n", media);
        }
    }
}

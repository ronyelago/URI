using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URI.Iniciante;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Vendedor: ");
            string nome = Console.ReadLine();

            Console.Write("Salário do Vendedor: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de vendas efetuadas: ");
            double vendas = double.Parse(Console.ReadLine());

            double liquido = Exercicio1009.SalarioBonus(salario, vendas);

            Console.WriteLine("Salário Liquido = R${0}\n\n", liquido);
            Console.ReadLine();
        }
    }
}

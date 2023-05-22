using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;

            Console.WriteLine("Lista 3, EX2");
            Console.WriteLine("Informe o 1º Valor: ");
            v1 = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Informe o 2º Valor (Maior que o 1º): ");
                v2 = double.Parse(Console.ReadLine());
            }
            while (v2 <= v1);
            Console.WriteLine("Aceito!");
        }
    }
}

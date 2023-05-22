using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            double result = 0;

            Console.WriteLine("LISTA 3, EX8");

            do
            {
                cont++;
                result = result + cont;

            } while (cont < 100);

            Console.WriteLine("A Soma dos Números Interiros Positivos no Itervalo de 1 a 100 é de: {0}", result);
        }
    }
}

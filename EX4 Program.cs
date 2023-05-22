

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            int cont = 0;

            Console.WriteLine("LISTA 3, EX4");

            do
            {
                cont++;
                valor = 5 * cont;
                Console.WriteLine("5 x {0} = {1}", cont, valor);
            } while (cont < 10);

        }
    }
}

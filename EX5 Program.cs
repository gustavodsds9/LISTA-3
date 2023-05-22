using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double result = 0;
            int cont = 0;

            Console.WriteLine("Lista 3, EX5");

            do
            {
                Console.WriteLine("Informe um Número: ");
                valor = int.Parse(Console.ReadLine());

            } while (valor < 0);
            Console.WriteLine("TABUADA DO ({0})", valor);
            do
            {
                cont++;
                result = valor * cont;
                Console.WriteLine("{0} x {1} = {2}", valor, cont, result);

            } while (cont < 10);
           
        }
    }
}

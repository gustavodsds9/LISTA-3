using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 0;
            double c = 1;

            while (c <= 20)
            {
                while ((a >= 1) && (a <= 10))
                {
                    b = c * a;
                    Console.WriteLine("{0} x {1} = {2}", c, a, b);
                    Console.WriteLine("Pressione Enter para continuar! ");
                    Console.ReadKey();

                    a++;
                }
                a = 1;
                b = 0;
                c++;
            }
        }
    }
}

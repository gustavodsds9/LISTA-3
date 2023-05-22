using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            Console.WriteLine("Lista 3, Ex 1:");

            do
            {
                Console.WriteLine("Informe o Valor:");
                valor = double.Parse(Console.ReadLine());
            } 
            while (valor < 0);
            Console.WriteLine("Valor: {0} Aceito!",valor);
        }
    }
}

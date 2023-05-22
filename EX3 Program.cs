using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            Console.WriteLine("Lista 3, EX3");

            do
            {
                Console.WriteLine("Informe o Sexo, (F) para Feminino, (M) para Mascolino: ");
                sexo = char.Parse(Console.ReadLine());
            }
            while (sexo != 'M' && sexo != 'F');
            Console.WriteLine("Sexo {0}", sexo);
        }
    }
}

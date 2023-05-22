using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resp;

            do
            {
                double val = 0;
                double cntd = 1;
                double ftrl = 1;
                Console.WriteLine("Informe o valor desejado:");
                val = double.Parse(Console.ReadLine());
                while (val < 0)
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Informe o valor desejado novamente: ");
                    val = double.Parse(Console.ReadLine());
                }
                do
                {
                    ftrl = ftrl * cntd;
                    cntd++;

                }
                while (cntd <= val);
                Console.WriteLine("{0}! = {1}", val, ftrl);
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("Executar Novamente (S) para Sim, (N) para Não?");
                    resp = char.Parse(Console.ReadLine());
                } while (resp != 'S' && resp != 'N');
            } while (resp != 'N');
        }
    }
}

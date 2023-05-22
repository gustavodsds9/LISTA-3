using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10__LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double maior = 0;
            double cont = 0;
            double soma = 0;
            double media = 0;

            Console.WriteLine("LISTA 3, EX10");

            do
            {
                cont++;
                Console.Write("Informe o {0}º Valor: ", cont);
                valor = double.Parse(Console.ReadLine());

                while (valor < 0)
                {
                    Console.WriteLine("ERRO MEU AMIGO!");
                    Console.WriteLine("Informe Novamente o {0}º Valor: ", cont);
                }
                if (valor > maior)
                {
                    maior = valor;
                }
                soma = soma + valor;

            } while (cont < 10);

            media = soma / 10;

            Console.WriteLine("");
            Console.WriteLine("Maior Valor: {0}", maior);
            Console.WriteLine("Soma dos Valores {0}", soma);
            Console.WriteLine("Média dos Valores: {0}", media);

        }
    }
}

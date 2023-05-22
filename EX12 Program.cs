using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_LISTA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resp;
            do

            {
                double qntd = 0;
                double i = 0;
                double valPos = 0;
                double valNeg = 0;
                double val = 0;
                double maior = 0;
                double menor = 0;
                double soma = 0;
                double media = 0;
                double pctgPos = 0;
                double pctgNeg = 0;



                Console.WriteLine("Informe a Quantidade de Valores Desejados:");
                qntd = double.Parse(Console.ReadLine());
                while (qntd < 0 || qntd >= 20)
                {
                    Console.WriteLine("ERRO MEU AMIGO!");
                    Console.WriteLine("Informe Novamente a Quantidade de Valores Desejados: ");
                    qntd = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
                while (i < qntd)
                {
                    i++;
                    Console.Write("{0}º Valor: ", i);
                    val = double.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        maior = menor = val;
                    }
                    else
                    {
                        if (val > maior)
                        {
                            maior = val;
                        }
                        else
                        {
                            if (val < menor)
                            {
                                menor = val;
                            }
                        }
                    }
                    soma = soma + val;
                    if (val >= 0)
                    {
                        valPos++;
                    }
                    else
                    {
                        valNeg++;
                    }
                }
                media = soma / qntd;
                pctgPos = valPos * 100 / qntd;
                pctgNeg = valNeg * 100 / qntd;
                Console.WriteLine("Maior Valor: {0}", maior);
                Console.WriteLine("Menor Valor: {0}", menor);
                Console.WriteLine("Soma dos Valores: {0}", soma);
                Console.WriteLine("Média Aritmética dos Valores: {0}", media);
                Console.WriteLine("Porcentagem dos Positivos: {0}%", pctgPos);
                Console.WriteLine("Porcentagem dos Negativos: {0}%", pctgNeg);
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

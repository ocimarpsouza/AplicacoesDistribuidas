using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    class E8
    {
        static void Main(string[] args)
        {
            double soma, media, valor;
            int n,a;
            Console.WriteLine("Quantas notas deseja digitar? ");
            n = int.Parse(Console.ReadLine());
            ArrayList lista_notas = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o valor da nota {0}:",(i+1));
                valor = double.Parse(Console.ReadLine());
                lista_notas.Add(valor);
            }

            soma = 0;
            foreach (double item in lista_notas)
            {
                soma += item;
            }

            media = soma / lista_notas.Count;

            Console.WriteLine("Média das notas é {0}", media);
            Console.WriteLine("Notas maiores que a média:");

            a = 0;
            foreach (double item in lista_notas)
            {
                a++;
                if (item > media)
                {
                    Console.WriteLine("Nota {0} valor: {1}", a, item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Notas menores que a média:");
            a = 0;
            foreach (double item in lista_notas)
            {
               a++;
                if (item <= media)
                {
                    Console.WriteLine("Nota {0} valor: {1}", a, item);
                }
            }

            Console.ReadKey();

        }
    }
}

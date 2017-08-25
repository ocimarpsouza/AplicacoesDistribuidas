using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class E1
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                int a = soma;
                soma += i;

                Console.WriteLine("A soma de {0} + {1} = {2}", a, i, soma);
            }

            Console.ReadKey();
        }
    }
}

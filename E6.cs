using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    class E6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int n = int.Parse(Console.ReadLine());

           
            while (n != -1)
            {
                Console.WriteLine("Usando FOR");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + "x " + i + " = " + (n * i));
                }

                Console.WriteLine();
                Console.WriteLine("Usando while");
                int j = 0;
                while (j < 10)
                {
                    j++;
                    Console.WriteLine(n + " x " + j + " = " + (n * j));
                }

                Console.WriteLine("Informe um número:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fim");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    class E5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando FOR");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" 5 x " + i + " = " + (5 * i));
            }
            Console.WriteLine();

            Console.WriteLine("Usando while");
            int j = 0;
            while (j < 10)
            {
                j++;
                Console.WriteLine(" 5 x " + j + " = " + (5 * j));

            }
            Console.ReadKey();
        }
    }
}

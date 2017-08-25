using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class E3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números divisiveis por 4 de 1 à 100:");
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write(i +" - ");
                }
            }
            Console.ReadKey();
        }
    }
}

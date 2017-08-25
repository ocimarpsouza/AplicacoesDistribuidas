using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class E2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Os números multiplos de 7 entre 1 e 200 são:");
            for (int i = 1; i < 200; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " - ");
                }
            }
            Console.ReadKey();
        }
    }
}

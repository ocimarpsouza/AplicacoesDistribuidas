using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    class E4
    {
        static void Main(string[] args)
        {
            float s = 0;
            Console.WriteLine("Calcular o valor de S usando a seguinte fórmula:");
            Console.Write("S = ");
            
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == 20)
                    {
                        Console.WriteLine("x/{0}", i);
                    }
                    else
                    {
                        Console.Write("x/{0} + ", i);
                    }
                    
                }
                else
                {
                    Console.Write("x/{0} - ", i);
                }

            }

            Console.WriteLine("Informe o valor de X:");
            float x = float.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    s -= (x / i);
                }
                else
                {
                    s += (x / i);
                }
                
            }

            Console.WriteLine("O valor de S é:{0}",s);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10
{
    class E10
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            float salario, reajuste;
            int i = 0;

            while (i != -1)
            {

                Console.WriteLine("Informe o valor do salário:");
                salario = float.Parse(Console.ReadLine());
                if (salario > 0)
                {               
                   lista.Add(salario);
                }
                else if (salario == -1) { i = -1; }

            }

            Console.WriteLine();

            Console.WriteLine("Informe o valor do reajuste:");
            reajuste = float.Parse(Console.ReadLine());

            foreach (float item in lista)
            {
                Console.WriteLine("Salário reajustado de R${0} => R${1}", item, item+reajuste);
            }

            Console.ReadKey();
        }
    }

    
}

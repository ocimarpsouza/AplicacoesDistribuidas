using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E9
{
    class E9
    {
        static void Main(string[] args)
        {

            ArrayList lista = new ArrayList();
            string nome;
            float n, notas, media;
            int i = 0;

            while (i != -1)
            {

                Console.WriteLine("Informe o nome do aluno ou -1 para sair.");
                nome = Console.ReadLine();
                if (nome != "-1")
                {
                    Console.WriteLine("Informe a nota");
                    n = float.Parse(Console.ReadLine());
                    Aluno a = new Aluno();
                    a.nome = nome;
                    a.nota = n;
                    lista.Add(a);
                }
                else { i = -1; }

            }

            Console.WriteLine();

            notas = 0;

            foreach (Aluno item in lista)
            {
                Console.WriteLine("Aluno: {0} - nota:{1}", item.nome, item.nota);
                notas += item.nota;
            }

            media = notas / lista.Count;
            Console.WriteLine();
            Console.WriteLine("A média das notas informadas é:{0}", media);
            Console.WriteLine();
            Console.WriteLine("Os alunos acima da média são:");
            foreach (Aluno item in lista)
            {
                if (item.nota > media)
                {
                    Console.WriteLine("Aluno: {0} - nota:{1}", item.nome, item.nota);
                }
            }
            Console.ReadKey();
        }
    }

    class Aluno
    {
        public String nome;
        public float nota;
    }
}
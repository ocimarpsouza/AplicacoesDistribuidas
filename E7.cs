using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    class E7
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            string tipo;
            float vlr = 0;
            int i = 0;

            while (i < 25)
            {

                Console.WriteLine("Informe o código da transação (v = à vista - p = à prazo) ou -1 para sair");
                tipo = Console.ReadLine();
                if (tipo == "v")
                {
                    i++;
                    Console.WriteLine("informe o valor da compra nº{0}:", i);
                    vlr = float.Parse(Console.ReadLine());
                    Compra c = new Compra
                    {
                        tipo = "v",
                        transacao = i,
                        valor = vlr,
                    };
                    lista.Add(c);
                }
                else if (tipo == "p")
                {
                    i++;
                    Console.WriteLine("informe o valor da parcela desta compra nº{0}:", i);
                    vlr = float.Parse(Console.ReadLine());
                    Compra c = new Compra
                    {
                        tipo = "P",
                        transacao = i,
                        valor = (vlr * 3)
                    };
                    lista.Add(c);
                }else if (tipo == "-1")
                {
                    return;
                }

            }

            float aVista = 0;
            float aPrazo = 0;

            Console.WriteLine("Trasações efetuadas:{0}", lista.Count);
            foreach (Compra item in lista)
            {
                if (item.tipo == "P")
                {
                    Console.WriteLine("Transação nº{0} - Tipo:{1} - Valor: 3 parcelas de R${2}", item.transacao, item.tipo, item.valor);
                    aPrazo = aPrazo += item.valor;
                }
                else
                {
                    Console.WriteLine("Transação nº{0} - Tipo:{1} - Valor:R${2}", item.transacao, item.tipo, item.valor);
                    aVista = aVista += item.valor;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Totais do dia:");
            Console.WriteLine("Valor total das compras à vista:R$ {0}", aVista);
            Console.WriteLine("Valor total das compras à prazo:R$ {0}", aPrazo);
            Console.WriteLine("Valor total das compras efetuadas:R$ {0}", aPrazo + aVista);
            Console.ReadKey();
        }
    }

    class Compra
    {
        public int transacao;
        public String tipo;
        public float valor;
    }
}


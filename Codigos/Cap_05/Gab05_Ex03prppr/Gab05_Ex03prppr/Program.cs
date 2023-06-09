using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex03prppr
{
    class Program
    {

        public static float Prestacao(float VALOR, float TAXA, float TEMPO)
        {
            float PRESTACAO = VALOR + (VALOR * (TAXA / 100) * TEMPO);
            return PRESTACAO;
        }

        static void Main(string[] args)
        {
            float PRESTACAO, VALOR, TAXA, TEMPO;
            Console.Write("Entre o valor ....: ");
            VALOR = float.Parse(Console.ReadLine());
            Console.Write("Entre a taxa .....: ");
            TAXA = float.Parse(Console.ReadLine());
            Console.Write("Entre o tempo ....: ");
            TEMPO = float.Parse(Console.ReadLine());
            Console.WriteLine();
            PRESTACAO = Prestacao(VALOR, TAXA, TEMPO);
            Console.WriteLine("Prestacao R$ {0:##,##0.00}", PRESTACAO);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

    }
}

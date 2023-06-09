using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex03prppv
{
    class Program
    {

        public static void Prestacao(float VALOR, float TAXA, float TEMPO)
        {
            float PRESTACAO = VALOR + (VALOR * (TAXA / 100) * TEMPO);
            Console.WriteLine("Prestacao R$ {0:##,##0.00}", PRESTACAO);
        }
        
        static void Main(string[] args)
        {
            float VALOR, TAXA, TEMPO;
            Console.Write("Entre o valor ....: ");
            VALOR = float.Parse(Console.ReadLine());
            Console.Write("Entre a taxa .....: ");
            TAXA = float.Parse(Console.ReadLine());
            Console.Write("Entre o tempo ....: ");
            TEMPO = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Prestacao(VALOR, TAXA, TEMPO);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

    }
}

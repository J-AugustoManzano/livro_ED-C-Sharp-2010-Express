using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab03_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            int V1, V2, DIF;

            Console.Write("Entre o 1o. valor: ");
            V1 = int.Parse(Console.ReadLine());
            Console.Write("Entre o 2o. valor: ");
            V2 = int.Parse(Console.ReadLine());

            if (V1 > V2)
                DIF = V1 - V2;
            else
                DIF = V2 - V1;
            Console.WriteLine();
            Console.WriteLine("Diferenca = {0}", DIF);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex04prppr
{
    class Program
    {

        public static int Potencia(int B, int E)
        {
            int P, I;
            P = 1;
            for (I = 1; I <= E; I++)
                P *= B;
            return P;
        }

        static void Main(string[] args)
        {
            int P, BASE, EXPOENTE;
            Console.Write("Entre a base ......: ");
            BASE = int.Parse(Console.ReadLine());
            Console.Write("Entre o exponete ..: ");
            EXPOENTE = int.Parse(Console.ReadLine());
            Console.WriteLine();
            P = Potencia(BASE, EXPOENTE);
            Console.WriteLine("Potencia = {0}", P);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex04prppv
{
    class Program
    {

        public static void Potencia(int BASE, int EXPOENTE)
        {
            int P, I;
            P = 1;
            for(I = 1; I <= EXPOENTE; I++)
                P *= BASE;           
            Console.WriteLine("Potencia = {0}", P);
        }

        static void Main(string[] args)
        {
            int BASE, EXPOENTE;
            Console.Write("Entre a base ......: ");
            BASE = int.Parse(Console.ReadLine());
            Console.Write("Entre o exponete ..: ");
            EXPOENTE = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Potencia(BASE, EXPOENTE);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

    }
}

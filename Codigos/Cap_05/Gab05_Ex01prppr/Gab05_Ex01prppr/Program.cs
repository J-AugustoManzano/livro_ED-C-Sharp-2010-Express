using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex01prppr
{
    class Program
    {
        static void Main(string[] args)
        {

            int X;
            long R;
            Console.Write("Entre um valor numerico: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            R = Somatorio(X);
            Console.WriteLine("Somatorio de ate {0} = {1}", X, R);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }

        public static long Somatorio(int N)
        {
            long SOMA = 0;
            for (int I = 1; I <= N; I++)
                SOMA += I;
            return SOMA;
        }

    }
}

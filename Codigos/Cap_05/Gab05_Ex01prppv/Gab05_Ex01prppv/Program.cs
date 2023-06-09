using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex01prppv
{
    class Program
    {
        static void Main(string[] args)
        {

            int X;
            Console.Write("Entre um valor numerico: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Somatorio(X);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }

        public static void Somatorio(int N)
        {
            long SOMA = 0;
            for (int I = 1; I <= N; I++)
                SOMA += I;
            Console.WriteLine("Somatorio de ate {0} = {1}", N, SOMA);
        }

    }
}

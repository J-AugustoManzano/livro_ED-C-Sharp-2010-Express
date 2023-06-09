using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab05_Ex02prppv
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            Console.Write("Entre o termo Fibonacci: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Fibonacci(X);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

        public static void Fibonacci(int N)
        {
            int ATUAL, ANTERIOR, PROXIMO;
            ANTERIOR = 0;
            ATUAL = 1;
            for (int I = 1; I <= N; I++)
            {
                PROXIMO = ATUAL + ANTERIOR;
                ANTERIOR = ATUAL;
                ATUAL = PROXIMO;
            }
            Console.WriteLine("Resultado = {0}", ANTERIOR);
        }
    }
}

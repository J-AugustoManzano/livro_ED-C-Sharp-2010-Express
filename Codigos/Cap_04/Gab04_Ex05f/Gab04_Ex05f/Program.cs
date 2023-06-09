using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex05f
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, I, ATUAL, ANTERIOR, PROXIMO;

            ANTERIOR = 0;
            ATUAL = 1;

            Console.Write("Qual termo Fibonacci: ");
            N = int.Parse(Console.ReadLine());

            for(I = 1; I <= N; I++)
            {
                PROXIMO = ATUAL + ANTERIOR;
                ANTERIOR = ATUAL;
                ATUAL = PROXIMO;
            }
            Console.WriteLine("Resultado = {0}", ANTERIOR);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

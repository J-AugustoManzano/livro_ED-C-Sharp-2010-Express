using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex05w
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

            I = 1;
            while (I <= N)
            {
                PROXIMO = ATUAL + ANTERIOR;
                ANTERIOR = ATUAL;
                ATUAL = PROXIMO;
                I++;
            }
            Console.WriteLine("Resultado = {0}", ANTERIOR);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

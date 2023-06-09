using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab06_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];

            int I;

            for (I = 0; I <= 9; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [A]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }

            for (I = 0; I <= 9; I++)
                B[I] = A[I] * A[I];
            Console.WriteLine();

            for (I = 0; I <= 9; I++)
                Console.WriteLine("B[{0,2}] = {1,4}", I + 1, B[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

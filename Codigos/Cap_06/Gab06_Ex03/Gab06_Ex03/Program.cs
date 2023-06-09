using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab06_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[9];
            int[] B = new int[9];
            int[] C = new int[9];

            int I;

            for (I = 0; I <= 8; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [A]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (I = 0; I <= 8; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [B]: ", I + 1);
                B[I] = int.Parse(Console.ReadLine());
            }

            for (I = 0; I <= 8; I++)
                C[I] = A[I] - B[I];
            Console.WriteLine();

            for (I = 0; I <= 8; I++)
                Console.WriteLine("C[{0}] = {1,4}", I + 1, B[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

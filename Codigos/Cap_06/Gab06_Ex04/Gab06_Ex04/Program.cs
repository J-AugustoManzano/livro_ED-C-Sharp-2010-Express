using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab06_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[8];
            int[] B = new int[8];
            int[] C = new int[16];

            int I;

            for (I = 0; I <= 7; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [A]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (I = 0; I <= 7; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [B]: ", I + 1);
                B[I] = int.Parse(Console.ReadLine());
            }

            for (I = 0; I <= 15; I++)
                if (I <= 7)
                    C[I] = A[I];
                else
                    C[I] = B[I - 8];
            Console.WriteLine();

            for (I = 0; I <= 15; I++)
                Console.WriteLine("C[{0,2}] = {1,4}", I + 1, C[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

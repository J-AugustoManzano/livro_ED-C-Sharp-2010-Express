using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab06_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[8];
            int[] B = new int[8];

            int I;

            for (I = 0; I <= 7; I++)
            {
                Console.Write("Entre {0,2}o. valor - arranjo [A]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }

            for (I = 0; I <= 7; I++)
                B[I] = A[7 - I];
            Console.WriteLine();

            for (I = 0; I <= 7; I++)
                Console.WriteLine("A[{0}] = {1} / B[{0}] = {2}", I + 1, A[I], B[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

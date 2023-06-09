using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab06_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            long[] B = new long[10];

            int I, J;

            for (I = 0; I <= 9; I++)
            {
                Console.Write("Entre {0,2}o. valor: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }

            for (I = 0; I <= 9; I++)
            {
                B[I] = 1;
                for (J = 1; J <= A[I]; J++)
                    B[I] *= J;
            }
            Console.WriteLine();

            for (I = 0; I <= 9; I++)
                Console.WriteLine("B[{0,2}] = {1,20}", I + 1, B[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

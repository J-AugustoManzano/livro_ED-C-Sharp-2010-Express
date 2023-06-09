using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab03_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, X;

            Console.Write("Entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <C>: ");
            C = int.Parse(Console.ReadLine());

            if (A > B)
            {
                X = A;
                A = B;
                B = X;
            }
            if (A > C)
            {
                X = A;
                A = C;
                C = X;
            }
            if (B > C)
            {
                X = B;
                B = C;
                C = X;
            }

            Console.WriteLine();
            Console.WriteLine("A posicao <A> vale: " + A.ToString());
            Console.WriteLine("A posicao <B> vale: " + B.ToString());
            Console.WriteLine("A posicao <C> vale: " + C.ToString());

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, D;
            int S1, S2, S3, S4, S5, S6;
            int M1, M2, M3, M4, M5, M6;

            Console.Write("Entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <C>: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <D>: ");
            D = int.Parse(Console.ReadLine());

            S1 = A + B;
            S2 = A + C;
            S3 = A + D;
            S4 = B + C;
            S5 = B + D;
            S6 = C + D;

            M1 = A * B;
            M2 = A * C;
            M3 = A * D;
            M4 = B * C;
            M5 = B * D;
            M6 = C * D;

            Console.WriteLine();
            Console.Write(S1.ToString() + " ");
            Console.Write(S2.ToString() + " ");
            Console.Write(S3.ToString() + " ");
            Console.Write(S4.ToString() + " ");
            Console.Write(S5.ToString() + " ");
            Console.WriteLine(S6.ToString());

            Console.WriteLine();
            Console.Write(M1.ToString() + " ");
            Console.Write(M2.ToString() + " ");
            Console.Write(M3.ToString() + " ");
            Console.Write(M4.ToString() + " ");
            Console.Write(M5.ToString() + " ");
            Console.WriteLine(M6.ToString());

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}

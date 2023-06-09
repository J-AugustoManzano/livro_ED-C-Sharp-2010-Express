using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab03_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double A, B, C, DELTA, X1, X2;

            Console.Write("Entre valor <A>: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Entre valor <B>: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Entre valor <C>: ");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (A != 0 && B != 0 && C != 0)
            {
                DELTA = Math.Pow(B, 2) * 4 * A * C;
                if (DELTA == 0)
                {
                    X1 = -B / (2 * A);
                    Console.WriteLine("X = {0:0.00}", X1);
                }
                else
                    if (DELTA > 0)
                    {
                        X1 = (-B + Math.Sqrt(DELTA))/(2 * A);
                        X2 = (-B - Math.Sqrt(DELTA))/(2 * A);
                        Console.WriteLine("X1 = {0:0.00}", X1);
                        Console.WriteLine("X2 = {0:0.00}", X2);
                     }
                    else
                        Console.WriteLine("Nao existem raizes reais");
            }
            else
                Console.WriteLine("Nao e equacao completa de 2o. grau.");

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

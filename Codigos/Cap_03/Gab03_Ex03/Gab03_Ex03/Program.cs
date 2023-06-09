using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab03_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            float N1, N2, N3, N4, MD;

            Console.Write("Entre a Nota 1: ");
            N1 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 2: ");
            N2 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 3: ");
            N3 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 4: ");
            N4 = float.Parse(Console.ReadLine());

            MD = (N1 + N2 + N3 + N4) / 4;

            if (MD >= 5)
                Console.Write("Aprovado com media ");
            else
                Console.Write("Reprovado com media ");
            Console.Write(MD.ToString("0.00"));

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

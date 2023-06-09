using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab03_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            float N1, N2, N3, N4, MD1, MD2, EX;

            Console.Write("Entre a Nota 1: ");
            N1 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 2: ");
            N2 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 3: ");
            N3 = float.Parse(Console.ReadLine());
            Console.Write("Entre a Nota 4: ");
            N4 = float.Parse(Console.ReadLine());

            MD1 = (N1 + N2 + N3 + N4) / 4;

            if (MD1 >= 7)
                Console.Write("Aprovado com media {0:0.00}", MD1);
            else
            {
                Console.Write("Entre o Exame: ");
                EX = float.Parse(Console.ReadLine());

                MD2 = (MD1 + EX) / 2;

                if (MD2 >= 5)
                    Console.Write("Aeprovado em exame com media ");
                else
                    Console.Write("Reprovado com media ");
                Console.Write(MD2.ToString("0.00"));
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

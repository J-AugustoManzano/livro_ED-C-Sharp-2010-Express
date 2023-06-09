using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex04w
{
    class Program
    {
        static void Main(string[] args)
        {

            int I;
            double SOMA, R;

            SOMA = 0;
            I = 2;
            while (I <= 5)
            {
                R = Math.Pow(I, 2);
                SOMA += R;
                I++;
            }
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

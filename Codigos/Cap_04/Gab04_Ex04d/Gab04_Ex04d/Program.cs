using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex04d
{
    class Program
    {
        static void Main(string[] args)
        {

            int I;
            double SOMA, R;

            SOMA = 0;
            I = 2;
            do
            {
                R = Math.Pow(I, 2);
                SOMA += R;
                I++;
            }
            while (I <= 5);
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

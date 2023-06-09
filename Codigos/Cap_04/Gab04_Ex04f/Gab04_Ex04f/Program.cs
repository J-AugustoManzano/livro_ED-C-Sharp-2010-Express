using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex04f
{
    class Program
    {
        static void Main(string[] args)
        {

            int I;
            double SOMA, R;

            SOMA = 0;
            for(I = 2; I <= 5; I++)
            {
                R = Math.Pow(I, 2);
                SOMA += R;
            }
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

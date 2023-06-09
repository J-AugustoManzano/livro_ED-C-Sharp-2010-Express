using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex02f
{
    class Program
    {
        static void Main(string[] args)
        {

            int SOMA, I;

            SOMA = 0;
            for(I = 1; I <= 100; I++)
                SOMA += I;
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

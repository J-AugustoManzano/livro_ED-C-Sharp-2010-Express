using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex02d
{
    class Program
    {
        static void Main(string[] args)
        {

            int SOMA, I;

            SOMA = 0;
            I = 1;
            do            
            {
                SOMA += I;
                I++;
            }
            while (I <= 100) ;
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

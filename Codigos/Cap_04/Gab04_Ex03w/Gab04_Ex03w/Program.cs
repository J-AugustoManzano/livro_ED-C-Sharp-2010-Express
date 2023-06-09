using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex03w
{
    class Program
    {
        static void Main(string[] args)
        {

            int SOMA, I, RESTO;

            SOMA = 0;
            I = 1;
            while (I < 200)
            {
                RESTO = I % 4;
                if (RESTO == 0)
                    SOMA += I;
                I++;
            }
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

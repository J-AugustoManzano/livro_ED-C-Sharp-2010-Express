using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex01w
{
    class Program
    {
        static void Main(string[] args)
        {

            int SOMA, I, RESTO;

            SOMA = 0;
            I = 0;
            while (I <= 20)
            {
                RESTO = I % 2;
                if (RESTO != 0)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab04_Ex01d
{
    class Program
    {
        static void Main(string[] args)
        {

            int SOMA, I, RESTO;

            SOMA = 0;
            I = 0;
            do
            {
                RESTO = I % 2;
                if (RESTO != 0)
                    SOMA += I;
                I++;
            }
            while (I <= 20);
            Console.WriteLine(SOMA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            float F, C;

            Console.Write("Entrada - Fahrenheit ...: ");
            F = float.Parse(Console.ReadLine());

            C = ((F - 32) * 5) / 9;

            Console.WriteLine("Saida - Celcius ........: " + C.ToString("0.0"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            float C, F;

            Console.Write("Entrada - Celcius ...: ");
            C = float.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5;

            Console.WriteLine("Saida - Fahrenheit ..: " + F.ToString("0.0"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();


        }
    }
}

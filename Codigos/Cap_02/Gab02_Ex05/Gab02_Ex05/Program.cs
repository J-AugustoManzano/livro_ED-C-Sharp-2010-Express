using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            double VOLUME, R, ALTURA;

            Console.Write("Entrada - Raio (R) ...: ");
            R = double.Parse(Console.ReadLine());
            Console.Write("Entrada - Altura .....: ");
            ALTURA = double.Parse(Console.ReadLine());

            VOLUME = 3.14159 * Math.Pow(R, 2) * ALTURA;

            Console.Write("Saida - Volume .......: ");
            Console.WriteLine(VOLUME.ToString("0.00"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            float TEMPO, VELOCIDADE, DISTANCIA, LITROS_USADOS;

            Console.Write("Entre o tempo .......: ");
            TEMPO = float.Parse(Console.ReadLine());
            Console.Write("Entre a velocidade ..: ");
            VELOCIDADE = float.Parse(Console.ReadLine());

            DISTANCIA = TEMPO * VELOCIDADE;
            LITROS_USADOS = DISTANCIA / 12;

            Console.WriteLine();
            Console.WriteLine("Tempo .........: " + TEMPO.ToString("0.00"));
            Console.WriteLine("Velocidade ....: " + VELOCIDADE.ToString("0.00"));
            Console.WriteLine("Distavia ......: " + DISTANCIA.ToString("0.00"));
            Console.WriteLine("Litros usados .: " + LITROS_USADOS.ToString("0.00"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}

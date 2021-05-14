using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gab02_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, X;

            Console.Write("Entre conteudo para <A>: ");
            A = Console.ReadLine();
            Console.Write("Entre conteudo para <B>: ");
            B = Console.ReadLine();

            X = A;
            A = B;
            B = X;

            Console.WriteLine();
            Console.WriteLine("Agora <A> esta com: " + A);
            Console.WriteLine("Agora <B> esta com: " + B);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}

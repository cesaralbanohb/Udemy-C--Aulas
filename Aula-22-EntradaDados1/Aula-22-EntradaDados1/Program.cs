using System;

namespace _22.EntradaDeDadosEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string p1 = vet[1];
            string p2 = vet[1];
            string p3 = vet[1];

            Console.WriteLine("voce digitou: ");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            string[] vet1 = Console.ReadLine().Split(' ');



        }
    }
}

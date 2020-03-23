using System;

namespace Aula_34_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;                
            }

            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma);
        }
    }
}

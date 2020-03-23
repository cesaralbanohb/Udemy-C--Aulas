using System;

namespace Aula_27_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que Horas são? ");

            int x = int.Parse(Console.ReadLine());

            if (x < 12)
            {
                Console.WriteLine("Manhã");
            }
            else if (x < 18) {
                Console.WriteLine("Tarde");
            }
            else {
                Console.WriteLine("Noite");
            }
        }
    }
}

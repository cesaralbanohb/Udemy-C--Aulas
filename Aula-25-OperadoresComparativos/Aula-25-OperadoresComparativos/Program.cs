using System;

namespace Aula_25_OperadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // comemtarios
            bool c1 = a < 10;

            Console.WriteLine(c1);

            bool a1 = 2 > 3 || 4 != 5;
            bool a2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(a1);
            Console.WriteLine(a2);

            bool a3 = false;

            Console.WriteLine(a3);
        }
    }
}

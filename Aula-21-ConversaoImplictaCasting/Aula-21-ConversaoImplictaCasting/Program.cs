using System;

namespace Aula_21_ConversaoImplictaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 5;
            int b = 2;

            double resultado = a / b;
            Console.WriteLine(resultado);

            double resultado2 = (double) a / b;
            Console.WriteLine(resultado2);
        }
    }
}

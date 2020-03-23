using System;

namespace Aula_OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a); ;

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "CDE";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 10;
            int f = ++e;
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}

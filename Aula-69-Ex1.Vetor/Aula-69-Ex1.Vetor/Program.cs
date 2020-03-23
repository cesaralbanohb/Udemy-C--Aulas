using System;
using System.Globalization;

namespace Aula_69_Ex1.Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            Console.WriteLine("Altura media = "
                + (sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Aula_70_Ex2.ProdPreco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qauntos produtoes deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] prod = new Produto[n];
            double sum = 0;

            

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto(nome, preco);
                sum += preco;

                double _2sum = Produto.Dobro(sum);
                Console.WriteLine(_2sum);
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(prod[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Preço médio = " + (sum / n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

using System;

namespace Aula_70_Ex1.AluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            int nQuarto = 10;

            Estudante[] vet = new Estudante[nQuarto];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                while (vet[quarto] != null)
                {
                    Console.Write("Quarto ocupado, escolha outro: ");
                    quarto = int.Parse(Console.ReadLine());
                }

                vet[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < nQuarto; i++)
            {
                if (vet[i] != null)
                    Console.WriteLine(i + ". " + vet[i]);
                else
                    Console.WriteLine(i + ". Quarto Vazio");
            }
        }
    }
}

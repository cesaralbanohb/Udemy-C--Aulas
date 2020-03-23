using System;
using System.Globalization;

namespace Aula_60_Exerc.Construt.This.Sobrecarga.Encapsula
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;

            Console.Write("Entre o número da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's' || sn == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(Numero, Titular, Saldo);
            }
            else
            {
                c1 = new Conta(Numero, Titular);
            }

            c1._operacao = 1;

            while (c1._operacao != 0)
            {
                c1.Opcoes();
                c1.Operacao = int.Parse(Console.ReadLine());

                if (c1._operacao == 2 && c1.Saldo < 0)
                {
                    Console.WriteLine("Saldo negativo. Não é permitido saque.");
                    Console.WriteLine(c1);
                }
                else
                {
                    if (c1._operacao == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Entre um valor para depósito: ");
                        c1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        Console.WriteLine(c1);
                        Console.WriteLine();
                    }
                    else if (c1._operacao == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Entre um valor para saque: ");
                        c1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        Console.WriteLine(c1);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

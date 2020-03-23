using System;
using System.Globalization;

namespace Aula_60_Exerc.Construt.This.Sobrecarga.Encapsula
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int _operacao;

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo + 5;
        }

        public int Operacao
        {
            get { return _operacao; }
            set
            {
                if (value < 0 || value > 2)
                {
                    while (value < 0 || value > 2)
                    {
                        Console.Write("Aplicação inválida, digite novamente: ");
                        value = int.Parse(Console.ReadLine());
                        _operacao = value;
                    }
                }
                else
                    _operacao = value;
            }
        }

        public void Opcoes()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("|  0. Sair         |");
            Console.WriteLine("|  1. Depositar    |");
            Console.WriteLine("|  2. Retirar      |");
            Console.WriteLine("|------------------|");
            Console.WriteLine("| Digite a operação|");
            Console.WriteLine("--------------------");
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

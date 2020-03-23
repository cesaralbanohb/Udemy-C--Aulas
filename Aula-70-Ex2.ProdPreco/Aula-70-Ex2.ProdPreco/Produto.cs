using System.Globalization;

namespace Aula_70_Ex2.ProdPreco
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        internal static double Dobro(double numero)
        {
            return numero * 2;
        }

    }
}

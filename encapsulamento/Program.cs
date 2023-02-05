using System;
using System.Globalization;

namespace encapsulamento
{
    class Program
    {
        private static void Main(string[] args)
        {

            //ClassProduto p = new ClassProduto(); // ClasseProduto
            ClassProduto p = new ClassProduto("TV", 900.00, 10); // ClasseProduto
            p.SetNome("TV 8K");
            Console.WriteLine(p.GetNome());

            p.SetPreco(1000.00);
            Console.WriteLine(p.GetPreco());

            p.SetQuantidade(10);
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
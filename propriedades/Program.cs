using System;
using System.Globalization;

namespace propriedades
{
    class Program
    {
        private static void Main(string[] args)
        {

            //ClassProduto p = new ClassProduto(); // ClasseProduto
            ClassProduto p = new ClassProduto("TV", 900.00, 10); // ClasseProduto
            p.Nome = "TV 8K";
            Console.WriteLine(p.Nome);

            p.Preco = 1000.00;
            Console.WriteLine(p.Preco);

            p.Quantidade = 10;
            Console.WriteLine(p.Quantidade);
        }
    }
}
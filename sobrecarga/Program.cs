using System;
using System.Globalization;

namespace sobrecarga
{
    class Program
    {
        private static void Main(string[] args)
        {
            // ClassProduto p = new ClassProduto(); // instancia os atributos da ClasseProduto

            Console.WriteLine("Entre com dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
           // int quantidade = int.Parse(Console.ReadLine());

            ClassProduto p = new ClassProduto(nome, preco); // Construtor da ClasseProduto

            Console.WriteLine(" "); // Com aspas duplas, linha em Branco

            //Modo Obcjet e ToString
            Console.WriteLine($"Dados do Produto: " + p);

            Console.WriteLine(); // Sem aspas dublas, linha em Branco
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdiconarProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            //OBS.: Pode aproveitar a variavel declarada, a qtde, para uma nova operacao
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
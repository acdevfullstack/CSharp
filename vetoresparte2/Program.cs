using System;
using System.Globalization;
using System.Numerics;

namespace vetoresparte2
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Achar a média dos elementos do vetor

            Console.Write("Entre com quantidades de produtos no vetor: ");
            int n = int.Parse(Console.ReadLine());

            ClassProduto[] vect = new ClassProduto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new ClassProduto { Nome = nome, Preco = preco }; // Instancia a Classe sem Construtor

            }

            double somar = 0.00;
            for (int i = 0; i < n; i++)
            {
                somar += vect[i].Preco;
            }

            double avg = somar / n;
            Console.WriteLine("AVARAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
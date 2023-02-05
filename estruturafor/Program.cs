using System;
using System.Globalization;


namespace estruturafor
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor; // outro modo ---> soma += valor;

            }
            */
            // outro exemplo
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.Write("Soma Total: " + soma);

        }
    }
}
using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padroes
using System.IO.Pipes;

namespace entradadedadosparte1
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("****************************");
            Console.WriteLine("Você digitou as seguintes cores: ");
            Console.WriteLine($"{frase}");
            Console.WriteLine($"{x} {y} {z}");
            Console.WriteLine($"{a} {b} {c}");
            Console.WriteLine("****************************");
            */

            //Exemplo com Vetor
            //string s = Console.ReadLine();
            //string[] vet = s.Split(' ');

            string[] vet = Console.ReadLine().Split(' '); //Desse jeito é mais simplificado com menos codigo
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine($"{p1} {p2} {p3}");



        }
    }
}
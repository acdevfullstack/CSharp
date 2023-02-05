using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padroes
using System.IO.Pipes;
using System.Xml;

namespace entradadedadosparte2
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //35
            char ch = char.Parse(Console.ReadLine()); //'F';
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //4.32;

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0]; //"Maria";
            char sexo = char.Parse(vet[1]);//"F";
            int idade = int.Parse(vet[2]);//23;
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); //1.68;


            /*
            string nome = //"Maria";
            char sexo = //"F";
            int idade = int.Parse(Console.ReadLine());//23;
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //1.68;
            */

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome + ' ' + sexo + ' ' + idade + ' ' + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
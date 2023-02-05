using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padros

namespace operadoresaritmeticos
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            //double n4 = 10 / 8; // resultado com expressao valor inteiro
            double n4 = (double)10 / 8; // resultado com expressao valor com casas decimais

            //Formula de equacao do 2º grau
            double a = 1.0, b = -3.0, c = -4.0;
            //Funcao normal
            //double delta = b * b - 4.0 * a * c;

            //Funcao alternativa
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Prepara a formula
            double x1 = (-b + Math.Sqrt(delta)) / 2.0 * a; // resultado da primeira raiz da equacao
            double x2 = (-b - Math.Sqrt(delta)) / 2.0 * a; // resultado da segunda raiz da equacao

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine($"{n4}");
            Console.WriteLine($"{delta:F2}");
            Console.WriteLine($"{x1:F2}");
            Console.WriteLine($"{x2:F2}");
        }
    }
}
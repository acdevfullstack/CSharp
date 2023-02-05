using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padros

namespace aula01
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
            // Valor de variavel = Float é igual 4 bits; Double é igual 8 bits;
            float x = 4.5f;
            double y = x;

            Console.WriteLine($"Valor de x é igual a {x.ToString("F2", CultureInfo.InvariantCulture)} e valor de y é de {y.ToString("F2", CultureInfo.InvariantCulture)}!");


            float b;
            double a;

            a = 5.1;
            b = (float)a;

            Console.WriteLine($"Valor de x é igual a {a.ToString("F2", CultureInfo.InvariantCulture)} e valor de b é de {b.ToString("F2", CultureInfo.InvariantCulture)}!");


            //No exemplo a baixo os valores serao truncados
            double a;
            int b;

            a = 9.1;
            b = (int)a;

            Console.WriteLine($"Valor de a é igual a {a} e valor de b é de {b}!");
            */

            //No exemplo a baixo os valores, tera que especificar o tipo de valor para aceitar as casas decimais
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;

            Console.WriteLine($"Valor de a é igual a {a} e valor de b é de {resultado.ToString("F2", CultureInfo.InvariantCulture)}!");

        }
    }
}
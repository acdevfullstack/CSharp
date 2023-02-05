using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Sintaxe simples
        /*
        double desconto;
        if (preco < 20.0)
        {
            desconto = preco * 0.1;
        }
        else
        {
            desconto = preco * 0.05;
        }
        */
        //Expressão ondicional termaria
        double desconto = (preco < 20.0) ? preco * 0.10 : preco * 0.05;
        Console.WriteLine("Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture));

    }
}
using System;
using System.Linq.Expressions;

namespace entradadedadosparte1
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
//int x = 10;
Console.WriteLine("Entre com número inteiro: ");
int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine($"Número é Par: {x}");
}
else
{
    Console.WriteLine($"Número é Ímpar: {x}");
}

Console.WriteLine(x);

Console.WriteLine("Bom dia!");

if (x < 5)
{
    Console.WriteLine("Boa tarde!");
}

Console.WriteLine("Boa noite!");

*/

            Console.WriteLine("Qual é hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Boa dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else 
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
using System;
using System.Globalization;

namespace modificadordeparams
{
    class Program
    {
        private static void Main(string[] args)
        {
            // int resultado = ClassCalculator.Soma(new int[] { 30, 2, 10, 8 });
             int resultado = ClassCalculator.Soma(30, 2, 10, 8, 10, 50, 100, 110, 51);
            /*
            int s1 = ClassCalculator.Soma(10, 5);
            int s2 = ClassCalculator.Soma(15, 5, 7);
            int s3 = ClassCalculator.Soma(30, 2, 10, 8);
            Console.WriteLine("Resultado com soma de dois números: " + s1);
            Console.WriteLine("Resultado com soma de três números: " + s2);
            Console.WriteLine("Resultado com soma de quatro números: " + s3);
            */

            Console.WriteLine("Resultado com soma de quatro números: " + resultado);
        }
    }
}
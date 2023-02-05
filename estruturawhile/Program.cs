using System;
using System.Globalization;


namespace estruturawhile
{
    class Program
    {
        private static void Main(string[] args)
        {
            // raiz quadrada

            Console.Write("Digite o número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"), CultureInfo.InvariantCulture);
                Console.Write("Digite o número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.Write("Número negativo!");

            /*
            // Outra Lógica
            bool b = true;
            while (b)
            {
                Console.Write("Digite o número: ");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"), CultureInfo.InvariantCulture);

                //if (x < 0.0) { b = false; }
                if (x < 0.0) { break; }
            }
            Console.Write("Número negativo!");
                        */
        }
    }
}
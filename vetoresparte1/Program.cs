using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;

namespace vetoresparte1
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Achar a média dos elementos do vetor

            Console.Write("Entre com quantidades de elementos no vetor: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double somar = 0.00;
            for (int i = 0; i < n; i++)
            {
                somar += vect[i];
            }

            double avg = somar / n;
            Console.WriteLine("AVARAGE HEIGTH = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
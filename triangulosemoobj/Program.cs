using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
     // Resolvendo problema sem orientação objetos
        double xA, xB, xC, yA, yB, yC;
        Console.WriteLine("Entre com as medidas do triângulo x: ");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Entre com as medidas do triângulo y: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Formulas
        double p = (xA + xB + xC) / 2.0;
        double areaX = Math.Sqrt(p* (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
        Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área do trinâgulo X: " + areaX);
        }
        else
        {
            Console.WriteLine("Maior área do trinâgulo Y: " + areaY);
        }

    }
}
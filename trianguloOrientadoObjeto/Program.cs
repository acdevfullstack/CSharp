using System;
using System.Globalization;
using trianguloOrientadoObjeto;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // Resolvendo problema com orientação objetos, utilizando classes, sem Funcao
        ClassTriangulo x, y;
        x = new ClassTriangulo();
        y = new ClassTriangulo();

        Console.WriteLine("Entre com as medidas do triângulo x: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Entre com as medidas do triângulo y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Formulas
        double p = (x.A + x.B + x.C) / 2.0;
        double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

        p = (y.A + y.B + y.C) / 2.0;
        double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
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
        */

        // Resolvendo problema com orientação objetos, utilizando classes, com Métado e Função
        ClassTriangulo x, y;
        x = new ClassTriangulo();
        y = new ClassTriangulo();

        Console.WriteLine("Entre com as medidas do triângulo x: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Entre com as medidas do triângulo y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Formulas
        double areaX = x.Area();
        double areaY = y.Area();

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
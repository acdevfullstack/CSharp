using membrosestaticosparte2;
using System;
using System.Globalization;

internal class Program
{

    private static void Main(string[] args)
    {
        /*
        ClassCalculadora calc = new ClassCalculadora();

        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = calc.Circunferencia(raio);
        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

        double volume = calc.Volume(raio);
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture)); 
        */

        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = ClassCalculadora.Circunferencia(raio);
        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

        double volume = ClassCalculadora.Volume(raio);
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de Pi: " + ClassCalculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }

}
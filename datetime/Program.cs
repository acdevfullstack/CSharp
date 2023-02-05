using System;
using System.Globalization;

namespace datetime
{
    class Program
    {
        private static void Main(string[] args)
        {
            /* Funcoes simples
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2022, 12, 25, 20, 30, 35);
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.UtcNow;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("DateTime.Now: " + d1);
            Console.WriteLine("Ticks: " + d1.Ticks);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("new DateTime: " + d2);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("DateTime.Today: " + d3);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("DateTime.UtcNow: " + d4);
            */

            //Funcoes mais complexas
            DateTime d1 = DateTime.Parse("2000-05-07");
            DateTime d2 = DateTime.Parse("2000-05-07 15:30:00");
            DateTime d3 = DateTime.ParseExact("2000-05-07", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d4 = DateTime.ParseExact("17/05/2000 17:30:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime: " + d1);
            Console.WriteLine("DateTime com horas: " + d2);
            Console.WriteLine("ParseExact data: " + d3);
            Console.WriteLine("ParseExact data e hora: " + d4);

        }
    }
}
using System;
using System.Globalization;

namespace timespan
{
    class Program
    {
        private static void Main(string[] args)
        {

            // Representa duração
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0, 1, 30);
            TimeSpan t3 = new TimeSpan(90000000000L);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //Instanciar quantidades de dias 
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);


            Console.WriteLine("TimeSpan: " + t1);
            Console.WriteLine("TimeSpan: " + t2);
            Console.WriteLine("TimeSpan.Ticks: " + t2.Ticks);
            Console.WriteLine("TimeSpan: " + t3);
            Console.WriteLine("TimeSpan: " + t4);
            Console.WriteLine("TimeSpan.FromDays: " + t6);
            Console.WriteLine("TimeSpan.FromHours: " + t7);
            Console.WriteLine("TimeSpan.FromMinutes: " + t8);
            Console.WriteLine("TimeSpan.FromSeconds: " + t9);
            Console.WriteLine("TimeSpan.FromMilliseconds: " + t10);
            Console.WriteLine("TimeSpan.FromTicks: " + t11);


        }
    }
}
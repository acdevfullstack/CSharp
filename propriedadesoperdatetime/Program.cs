using System;
using System.Globalization;

namespace propriedadesoperdatetime
{
    class Program
    {
        private static void Main(string[] args)
        {

            //Operações com Datretime
            DateTime d = new DateTime(2022, 8, 15, 13, 45, 58);
            DateTime dacr = DateTime.Now;

            DateTime d4= new DateTime(2022, 10, 15);
            DateTime d5 = new DateTime(2022, 10, 18);

            TimeSpan t1 = d5.Subtract(d4);

            DateTime d1 = d.AddHours(2);
            DateTime d2 = d.AddMinutes(3);
            DateTime d3 = dacr.AddDays(7);

            Console.WriteLine("Horas: " + d);
            Console.WriteLine("d.AddHours: " + d1);
            Console.WriteLine("d.AddMinutes: " + d2);
            Console.WriteLine("d.AddDays: " + d3);

            Console.WriteLine("---------------------------------- ");
            Console.WriteLine("d4.Subtract(d5): " + t1);

            /*
            DateTime d = new DateTime(2022, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine("1 - d.ToLongDateString: " + s1);
            Console.WriteLine("2 - d.ToLongTimeString: " + s2);
            Console.WriteLine("3 - d.ToShortDateString: " + s3);
            Console.WriteLine("4 - d.ToShortTimeString: " + s4);
            Console.WriteLine("4 - d.ToString: " + s5);
            Console.WriteLine("4 - d.ToString(yyyy-MM-dd HH:mm:ss): " + s6);
            Console.WriteLine("4 - d.ToString(yyyy-MM-dd HH:mm:ss.fff): " + s7);
*/
            /*
            DateTime d = new DateTime(2022, 8, 15, 13, 45, 58, 275);
            Console.WriteLine("1 - Date: " + d.Date);
            Console.WriteLine("2 - Day: " + d.Day);
            Console.WriteLine("3 - DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4 - DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5 - Hour: " + d.Hour);
            Console.WriteLine("6 - Kind: " + d.Kind);
            Console.WriteLine("7 - Millisecond: " + d.Millisecond);
            Console.WriteLine("8 - Minute: " + d.Minute);
            Console.WriteLine("9 - Month: " + d.Month);
            Console.WriteLine("10 - Second: " + d.Second);
            Console.WriteLine("11 - Ticks: " + d.Ticks);
            Console.WriteLine("12 - TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13 - Year: " + d.Year);
            */
        }
    }
}
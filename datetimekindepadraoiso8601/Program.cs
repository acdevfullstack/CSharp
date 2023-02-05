using System;
using System.Runtime.Intrinsics.X86;

namespace datetimekindepadraoiso8601
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Converter um Datetime para data local ou utc
            /*
            DateTime d1 = new DateTime(2023, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2023, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2023, 8, 15, 13, 5, 58);
            */

            /*
            Console.WriteLine("DateTimeKind.Local: " + d1);
            Console.WriteLine("DateTimeKind.Utc: " + d2);
            Console.WriteLine("DateTime: " + d3);
            */

            /*
            Console.WriteLine("d1 - DateTime: " + d1);
            Console.WriteLine("d1 - Kind: " + d1.Kind);
            Console.WriteLine("d1 - Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 - Utc: " + d1.ToUniversalTime());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("d2 - DateTime: " + d2);
            Console.WriteLine("d2 - Kind: " + d2.Kind);
            Console.WriteLine("d2 - Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 - Utc: " + d2.ToUniversalTime());
            */

            //Padrão ISO 8601
            //Formato mais utilizado (yyyy-MM-ddTHH:mm:ssZ)
            // Z - Indica que a data / hora esta em Utc
            DateTime d1 = DateTime.Parse("2022-8-15 13:05:58");
            DateTime d2 = DateTime.Parse("2022-8-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 - Kind: " + d1.Kind);
            Console.WriteLine("d1 - Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 - Utc: " + d1.ToUniversalTime());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 - Kind: " + d2.Kind);
            Console.WriteLine("d2 - Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 - Utc: " + d2.ToUniversalTime());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("d2 - formato ToString => 'yyyy-MM-ddTHH:mm:ssZ': " + d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado! 
            Console.WriteLine("d2 - formato ToUniversalTime => 'yyyy-MM-ddTHH:mm:ssZ': " + d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); 

        }
    }
}
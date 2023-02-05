namespace propriedadesopertimespan
{
    class Program
    {
        private static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);

            Console.WriteLine("TimeSpan t1: " + t1);
            Console.WriteLine("TimeSpan t2: " + t2);

            Console.WriteLine("Soma: " + sum);
            Console.WriteLine("Subtracao: " + dif);
            Console.WriteLine("Multiplicao: " + mult);
            Console.WriteLine("Divisao: " + div);

            /*
            TimeSpan t1 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("TimeSpan: " + t1);
            Console.WriteLine("Days: " + t1.Days);
            Console.WriteLine("Hours: " + t1.Hours);
            Console.WriteLine("Minutes: " + t1.Minutes);
            Console.WriteLine("Seconds: " + t1.Seconds);
            Console.WriteLine("Milliseconds: " + t1.Milliseconds);
            Console.WriteLine("Ticks: " + t1.Ticks);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("TotalDays: " + t1.TotalDays);
            Console.WriteLine("TotalHours: " + t1.TotalHours);
            Console.WriteLine("TotalMinutes: " + t1.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t1.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t1.TotalMilliseconds);
            */

            /*
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("MaxValue: " + t1);
            Console.WriteLine("MinValue: " + t2);
            */
        }
    }
}
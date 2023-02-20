using System;
using extension_methods.Extensions;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2023, 1, 1, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        Console.WriteLine("-----------------------");

        string s1 = "Good morning dear studentes!";
        Console.WriteLine(s1.Cut(10));

    }
}
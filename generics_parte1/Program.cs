﻿using System;

namespace generics_parte1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService<int> printService = new PrintService<int>();
           // PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}

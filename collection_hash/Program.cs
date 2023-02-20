using System;
using System.Collections.Generic;
using collection_hash_test_equality.Entities;

namespace collection_hash_test_equality
{
    class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            //Classe
            a.Add(new Product("TV", 500.00));
            a.Add(new Product("Notebook", 7000.00));
            a.Add(new Product("Table", 300.00));

            //Struct
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 7));
            b.Add(new Point(9, 10));

            Product prod = new Product("Notebook", 7000.00);
            Point p = new Point(9, 10);

            Console.WriteLine(a.Contains(prod));
            Console.WriteLine(b.Contains(p));



            /*
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Alex");
            set.Add("Bob");

            Console.WriteLine(set.Contains("Maria"));

            */

        }
    }
}
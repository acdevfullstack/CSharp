using System;
using System.Collections.Generic;
using System.Globalization;

namespace hashset_sortedset_parte2
{
    class Program
    {
        static void Main(string[] args)
        {
           // SortedSet<string> set = new SortedSet<string>();

            SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintColletion(c);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintColletion(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintColletion(e);

            /*
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Table");

            // Console.WriteLine(set.Contains("Notebook"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            */
        }

        //Funcao, utilizando interface
        static void PrintColletion<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
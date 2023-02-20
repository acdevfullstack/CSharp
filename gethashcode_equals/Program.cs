using System;
using gethashcode_equals.Entities;

namespace gethashcode_equals
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
              string a = "Maria";
              string b = "Bob";

              Console.WriteLine(a.GetHashCode());
              Console.WriteLine(b.GetHashCode());
             */

            string msg = "As informações de (a e b), são iguais ---> ";
            Client a = new Client { Name = "Anna", Email = "anna@gmail.com" };
            Client b = new Client { Name = "Renata", Email = "anna@gmail.com" };

            //Exemplos
            Console.WriteLine("*******Equals*******");
            Console.WriteLine("Name:  " + a.Name);
            Console.WriteLine("Email: " + a.Email);
            Console.WriteLine();
            Console.WriteLine("Name:  " + b.Name);
            Console.WriteLine("Email: " + b.Email);
            Console.WriteLine();
            Console.WriteLine(msg + a.Equals(b));
            //Console.WriteLine(msg + (a == b));
            Console.WriteLine();
            Console.WriteLine("*******GetHashCode*******");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(msg + (a == b));

        }
    }
}
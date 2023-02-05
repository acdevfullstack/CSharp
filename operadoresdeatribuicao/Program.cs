using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padros

namespace aula01
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
// Operador Atribuicao
int a = 10;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

a += 2;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

a -= 2;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

a *= 2;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

a /= 2;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

a %= 2;
Console.WriteLine("Valor de: " + a.ToString("F2", CultureInfo.InvariantCulture));

// Concatenar Caracteres
string s = "ABC";
Console.WriteLine(s);
s += "DEF";
Console.WriteLine(s);


Console.WriteLine("Valor de: " + b);
Console.WriteLine("Valor de: " + c);
Console.WriteLine("Valor de: " + d);
Console.WriteLine("Valor de: " + e);
Console.WriteLine("Valor de: " + f);
*/
            // Operador Aritmétrica de Atribuicao (++ ee --)_
            //Exemplos a++; ++a;  ou a--; --a;
            //Obs.: Utilizados em casos em laços de While e For

            //  int a = 10;
            //  a++;
            //   Console.WriteLine("Valor de: " + a);
            //   a--;
            //   Console.WriteLine("Valor de: " + a);

            //int a = 10;
            //int b = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
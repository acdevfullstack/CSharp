using System;
using System.Globalization; // Biblioteca que conclui formatação de casas decimais em varios padroes

namespace saidadedados
{
    class Program
    {
        static void Main(string[] args)
        {
            //char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            /* Bloco de comentario
Console.WriteLine("------------Saida de Dados no C#-------------------------");

Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(idade);
Console.WriteLine(nome);
Console.WriteLine(saldo);
Console.WriteLine(saldo.ToString("F2")); // Casas decimais com separação de virgula
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // Casas decimais com separação de ponto

Console.WriteLine("-----------------------------------------------");
*/

            //Placeholders
            Console.WriteLine("------------Placeholders no C#-------------------------");
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais!", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            //Ou
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais!", nome, idade, saldo);

            //Interpolação Esta funcao esta liberada apartir da versao .Net 6
            Console.WriteLine("------------Interpolação no C#-------------------------");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais!");

            //Concatenação 
            Console.WriteLine("------------Concatenação no C#-------------------------");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais! ");





        }
    }
}
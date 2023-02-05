using System;
using System.Collections.Generic; // Biblioteca Listas genéricas
using System.Security.Cryptography;

namespace listasparte2
{
    class Program
    {
        private static void Main(string[] args)
        {

            //List<string> list2 = new List<string>() { "Maria", "João", "Pedro" };
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("João");
            list.Add("Pedro");
            list.Add("Matheus");
            list.Add("Angelina");
            list.Add("Renata");
            list.Add("Andréia");

            list.Insert(2, "Ana"); // Adiciona o item na posição do indice especificado.

            //Obs.: A variável que exibe os elementos da lista pode ser qualquer nome que desejar. Exemplo: obj, item, lista, etc...
            foreach (string item in list)

            {
                Console.WriteLine(item);
            }

            //Mostra o tamanho da lista
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Tamanho da Lista: " + list.Count);

            Console.WriteLine("-------------------------------------");

            // Funcao Lambda, utilizando com listas
            //Primeira ocrrência da lista
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Find 'A': " + s1);

            //Ultima ocorrência da lista
            Console.WriteLine("-------------------------------------");
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("FindLast 'M': " + s2);

            //Primeira posição, index da ocorrência lista
            Console.WriteLine("-------------------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("FindIndex 'A': " + pos1);

            //Ultima posição, index da ocorrência lista
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("FindLastIndex 'A': " + pos2);

            Console.WriteLine("-------------------------------------");
            // Lista todos os elementos da lista conforme o tamanho de strings definido no Findall.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //Remove da lista a "Ana"
            list.Remove("Ana");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //Remove todos elementos da lista que começa com letra "M"
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //Remove elementos da lista em uma determinada poosição            
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");
            //Remove alguns elementos da lista em uma determinada posição.
            list.RemoveRange(1, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
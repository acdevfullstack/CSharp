using System;
using System.IO;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temp\myfolder";

        try
        {
            //Lista pastas de um determinado path
            //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

            Console.WriteLine("FORDERS: ");
            foreach (string s in folders )
            {
                Console.WriteLine(s);
            }

            //Lista arquivos de um determinado path]
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            Console.WriteLine("FILES: ");
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

            //Criar uma nova pasta
            Directory.CreateDirectory(path + @"\newfolder"); // Se desejar colocar o path da nova pasta diferente de @, e so colocar  \\ na frente



        }
        catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }

    }
}
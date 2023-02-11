using System;
using System.IO;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temp\filecsharp.txt";

        //Primeira Solucao
        /*
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            //fs = File.OpenRead(path);                                     
            fs = new FileStream(path, FileMode.Open); //Abrir arquivo
            sr = new StreamReader(fs); //Ler arquivo
            string line = sr.ReadLine();
            Console.WriteLine(line);

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }
        finally
        {
           if (fs != null) fs.Close();
           if (sr != null) sr.Close();
        }
        */

        //Segunda Solucao
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }

    }
}
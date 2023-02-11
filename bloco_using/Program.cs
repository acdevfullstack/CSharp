using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temp\filecsharp.txt";

        try
        {
            // Essa solucao tem a vantagem de, abrir e fechar o(s) bloco(s), mas nao e a mais simplicicada
            /*
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            */
            // Essa solucao tem a vantagem de, abrir e fechar o(s) bloco(s), e a mais simplicicada
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }
    }
}
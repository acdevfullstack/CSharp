using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcepath = @"C:\Temp\filecsharp.txt";
        string targetpath = @"C:\Temp\filecsharp2.txt";

        try
        {
            //FileInfo fileinfo = new FileInfo(sourcepath);
            //fileinfo.CopyTo(targetpath);

            string[] lines = File.ReadAllLines(targetpath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }


    }
}
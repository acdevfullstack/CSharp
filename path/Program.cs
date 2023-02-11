using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temp\myfolder\filecsharp1.txt";

        try {
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        } catch (IOException e)
        {
            Console.WriteLine("An error occorred!");
            Console.WriteLine(e.Message);
        }
    }
}
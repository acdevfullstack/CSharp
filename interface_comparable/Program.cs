using System;
using System.IO;
using System.Collections.Generic;
using interface_comparable.Entities;

namespace interface_comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo arquivo .txt
            //string path = @"C:\Temp\myfolder\filecsharp1.txt";
            /*
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }                   
                    list.Sort();
                    //Exibir informações da lista
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                    
                    sr.Close();
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred!");
                Console.WriteLine(e.Message);
            }
            */

            // Exemplo com arquivo .csv
            string path = @"C:\Temp\myfolder\filecsharp2.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    //Exibir informações da lista
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }

                    sr.Close();
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
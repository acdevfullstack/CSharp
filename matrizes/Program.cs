using System;
using System.Collections.Generic; // Biblioteca Listas genéricas
using System.Security.Cryptography;

namespace matrizes
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
            //Matriz, instanciar 2 linhas e 3 Colunas.
            double[,] mat = new double[2,3];
            Console.WriteLine("Total de elementos na matriz: " + mat.Length);
            Console.WriteLine("Dimensão da matriz: " + mat.Rank);
            Console.WriteLine("Dimensão da matriz, total de linhas: " + mat.GetLength(0));
            Console.WriteLine("Dimensão da matriz, total de colunas: " + mat.GetLength(1));
            */

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            //Percorrer a Matriz
            for (int i = 0; i < n; i++)
            {
                // Guarda os valores de cada linha e Coluna
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(valores[j]);

                }
            }

            // Exibir os valores da Diogonal da matriz
            Console.WriteLine("----------------------");
            Console.Write("Main diagonal:");
            //Percorrer a Matriz
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine("----------------------");

            //Percorrer a Matriz para guardar somente números negativos
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if (mat[i, j] < 0)
                    {
                        c++;
                    } 

                }
            }
            Console.WriteLine("Total de números Negativos: " + c);
            Console.WriteLine("----------------------");

        }
    }
}
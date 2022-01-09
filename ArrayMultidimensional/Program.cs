using System;

namespace ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 2]
            {
                // {} é linhas e dentro é coluna
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8}
            };
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}

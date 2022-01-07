using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int [3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            System.Console.WriteLine("Primeiro");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }
            System.Console.WriteLine("Segundo");
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
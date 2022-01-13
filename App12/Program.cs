using System;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {1, 5}, {2, 3}, {3, 8}, {4, 1} };
            for (int i = 0; i < array.GetLength(0); i++)
                {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                    Console.Write(array[i,j] + " ");
                    }   
                Console.WriteLine();       
                }       
        }
    }
}

using System;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] arr2 = new int [10,5];

            PrintArray2d(arr2);
        }

        static void PrintArray2d(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) ; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

using System;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [10, 10];
            Random ships = new Random();
            for (int i = 0; i < 10; i++)
            {                               
                for (int j = 0; j<10; j++)
                {
                    //array[i,j] = ships.Next(0,2);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }     
        }
    }
}

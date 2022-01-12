using System;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {1, 1}, {2, 1}, {3, 1}, {3, 1} };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }           
        }
    }
}

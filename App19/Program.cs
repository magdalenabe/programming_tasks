using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 1, 2, 3, 4, 5, 6};
            PrintArray(arr);
        }

        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
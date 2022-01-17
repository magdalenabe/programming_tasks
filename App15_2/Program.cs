using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 13, 45, 11, 9, 67 };
            //Bubble sort
            for (int i = 0; i < array.Length; i++)
            {
                int bubble;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        bubble = array[j];
                        array[j] = array[i];
                        array[i] = bubble;
                    }
                }
                for (int a = 0; a < array.Length; a++)
                {
                    Console.Write(array[a] + " ");
                }
                    Console.WriteLine();
            }    
        }
    }
}

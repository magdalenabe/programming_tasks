using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 13, 45, 11, 9, 67 };
            Console.WriteLine("Specify the sort order (asc for ascending and desc for descending):");
            string order = Console.ReadLine();
            PrintArray(arr, order);
            //if (order is "asc")
            //{
            //    PrintArrayAsc(arr);
            //}
            //else if (order is "desc")
            //{
            //    PrintArrayDesc(arr);
            //}
        }

        static void PrintArray(int[] array, string sortingMethod)
        {
            if (sortingMethod is "asc")
            {
                PrintArrayAsc(array);
            }
            else if (sortingMethod is "desc")
            {
                PrintArrayDesc(array);  
            }
            else
            {
                Console.WriteLine("The sort order you specify does not exist");
            }
        }
        static void PrintArrayAsc(int[] array)
        {
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
                Console.Write(array[i] + " ");
            }
        }
        static void PrintArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int bubble;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        bubble = array[j];
                        array[j] = array[i];
                        array[i] = bubble;
                    }
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}

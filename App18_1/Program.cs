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
             if (order == "asc")
                SortArray(arr, true);
            else
                SortArray(arr, false);
        }

 
        static void SortArray(int[] array, bool asc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int bubble;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (asc)
                    {
                        if (array[i] > array[j])
                        {
                            bubble = array[j];
                            array[j] = array[i];
                            array[i] = bubble;
                        }
                    }
                    else
                    {
                        if (array[i] < array[j])
                        {
                            bubble = array[j];
                            array[j] = array[i];
                            array[i] = bubble;
                        }

                    }
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}

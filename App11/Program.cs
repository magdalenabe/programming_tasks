using System;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7};
            for (int i = array[0]; i<=array.Length; i++)
            {
                Console.WriteLine(i);
            }
              
            /*int[] array = {1, 2, 3, 4, 5, 6, 7};
            foreach (int i in array)
            {
                Console.WriteLine(i);*/
            }
        }
    }


using System;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 6, 2, 4, 1 };
            int min;
            min = array[0];
            int temp;
            for (int i = 0; i < array.Length -1 ; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] < min) min = array[i];
                }
                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

    }
}

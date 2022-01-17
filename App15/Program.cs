using System;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 1, 2, 4, 1 };
            //Selection sort
            for (int i = 0; i < array.Length - 1 ; i++)
            {
                int min = array[i];
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j]; 
                        minIndex = j;   
                    }
                }

                int temp = array[i];
                array[i] = min;
                array[minIndex] = temp;
                for (int a = 0; a < array.Length; a++)
            {
                Console.Write(array[a] + " ");
            }
                Console.WriteLine();
            }

            
            
        }

    }
}

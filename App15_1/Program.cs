using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 1, 2, 4, 1 };
            //Selection sort from the end of the list
            for (int i = array.Length - 1 ; i >= 0; i--)
            {
                int max = array[i];
                int maxIndex = i;
                for (int j = 0 ; j < i; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        maxIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = max;
                array[maxIndex] = temp;
                for (int a = 0; a < array.Length; a++)
                {
                    Console.Write(array[a] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

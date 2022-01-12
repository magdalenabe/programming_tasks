using System;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rndInteger = new Random();
            int min; 
            int max;
       
            for( int i = 0; i < array.Length; i++)
            {
                array[i] = rndInteger.Next(1, 21);
                Console.WriteLine(array[i]);
            }
            min = array[0];
            max = array[0];
            for( int i = 0; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
                if (max < array[i]) max = array[i];
            }
            Console.WriteLine($"The min value: {min}");
            Console.WriteLine($"The max value: {max}");

        }
    }
}

using System;

namespace App22
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"The random number is: {RandomValue()}");

        }
        static int RandomValue()
        {
            Console.WriteLine("Specify min value:");
            var minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify max value:");
            var maxValue = int.Parse(Console.ReadLine());

            if (minValue > maxValue)
            {
                throw new InvalidOperationException("Min value should be less than max value.");

            }

            Random random = new Random();
            int randomValue = random.Next(minValue, maxValue);
            return randomValue;
        }
    }
}


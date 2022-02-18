using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"The random number is: {RandomValue()}");
                    break;

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Specified value must be an integer");
                    Console.WriteLine("Try again");
                }
                
                // finally
                // {
                //     Console.WriteLine();
                // }
            }


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


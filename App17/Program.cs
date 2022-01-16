using System;

namespace App17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(GetRandomNr());
        }
        static int GetRandomNr()
        {
            Console.WriteLine("Specify min number:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify max number:");
            int max = int.Parse(Console.ReadLine());

            Random number = new Random();
            int value = number.Next(min, max);
            return value;
        }
    }
}

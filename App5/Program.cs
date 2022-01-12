using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rNumber = new Random();
            Console.WriteLine("Random number from 0 to 99:");
            Console.WriteLine(rNumber.Next(0,100));
        }
    }
}

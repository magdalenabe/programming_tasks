using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} !");
        }
    }
}

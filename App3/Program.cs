using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine($"Hello {name} {surname} !");
        }
    }
}
using System;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = GetName();
            var surname = GetSurname();
            Console.WriteLine($"Hello {name} {surname} !");
        }
        static string GetName()
        {
            Console.WriteLine("What's your name?");
            return Console.ReadLine();
        }
        static string GetSurname()
        { 
            Console.WriteLine("What's your surname?");
            return Console.ReadLine();
        }
    }
}

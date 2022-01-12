using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number:");
            int y = int.Parse(Console.ReadLine());
            int add = x + y;
            int substract = x - y;
            int multiply = x * y;
            int modulo = x % y;
            Console.WriteLine($"Addition result: {add}");
            Console.WriteLine($"Substract result: {substract}");
            Console.WriteLine($"Multiply result: {multiply}");
            Console.WriteLine($"Modulo result: {modulo}");

        }
    }
}

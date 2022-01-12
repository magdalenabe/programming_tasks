using System;

namespace App9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int value = number.Next(1,10);
            Console.WriteLine("Guess a number from 1 to 9:");
            int toGuess = int.Parse(Console.ReadLine());

            if (value == toGuess)
            {
                Console.WriteLine("Great!");
            }
            else
            {
                Console.WriteLine("You didn't guess a number");
            }
        }
    }
}

using System;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int value = number.Next(1000);
            Console.WriteLine("Guess a number from 0 to 999:");
            int toGuess = 0;
            while (value != toGuess)
            {
                toGuess = int.Parse(Console.ReadLine());

                if (value > toGuess)
                {
                Console.WriteLine($"The number is bigger than {toGuess}");
                }
                else if (value < toGuess)
                {
                Console.WriteLine($"The number is lower than {toGuess}");
                }
            }
           
            Console.WriteLine($"Great, you guessed. The number is {value}");
            
        }
    }
}

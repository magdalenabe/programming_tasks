using System;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num1 = int.Parse(Console.ReadLine());
            if ((num1 > 60) && (num1 % 2 == 0 ) && (num1 % 3 == 0 ))
            {
                Console.WriteLine("Great!");
            }
            else
            {
                Console.WriteLine("Entered number must be bigger than 60 and can be divided by 2 and 3");
            }
            

            /*Console.WriteLine("Enter the number:");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > 60)
            {
                if (num2 % 2 != 0)
                {
                    Console.WriteLine("This number is not divisble by 2");
                }
                else if (num2 % 3 != 0)
                {
                    Console.WriteLine("This number is not divisble by 3");
                }
                else
                {
                    Console.WriteLine("Great!");
                }
            }
            else
            {
                Console.WriteLine("Entered number must be bigger than 60");
            }*/
        }
    }
}
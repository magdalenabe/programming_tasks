using System;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = {10, 20, 30, 40, 50};
            int[] a2 = {10, 20, 30, 40, 50};
            bool comp = a1 == a2;
            Console.WriteLine(comp);
            Console.WriteLine(a1.Equals(a2));
            Console.WriteLine(a1 == a2);
            
        }
    }
}

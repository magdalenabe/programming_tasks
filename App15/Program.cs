using System;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = {5, 3, 6, 2, 4, 1};
            
            for (int i = 0; i <= array.Length; i++)
            {
                int min = i;
                for (var j = i+1; j <= array.Length; j++)
                    if (array[j] < array[min])
                    var min = j;
            
                if ( min != i)
                {
                    var sort = array[j];
                    array[j] = array[min];
                    array[min] = sort;
                }
             /*return Console.WriteLine(array);   */                   
                
            }
            
        }
    }
}

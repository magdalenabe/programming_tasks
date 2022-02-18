using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Animal
    {
        protected string _name; //properties
        static int count = 0;
        public void Print()
        {
            PrintAnimal();
        }

        public Animal(string name) // konstruktor
        {
            _name = name;
            count ++;
        }
        //public string Name()
        //{ return _name; }

        public void Say()
        {
            Console.WriteLine($"I'm {_name}");
        }
        public virtual void GiveVoice()
        {
            Console.WriteLine("???????");
        }

        protected virtual void PrintAnimal()
        {
            Console.WriteLine("Default");
        }

        public static void CountAnimal()
        {
            {
                Console.WriteLine($"You created {count} animals");
            }
        }
    }
}

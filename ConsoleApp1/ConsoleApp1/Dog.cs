using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void GiveVoice()
        {
            Console.WriteLine("Woof!");
        }
        protected override void PrintAnimal()
        {
            Console.WriteLine("Dog");
        }

    }
}

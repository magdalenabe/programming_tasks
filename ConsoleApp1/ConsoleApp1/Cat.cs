using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void GiveVoice()
        {
            Console.WriteLine("Meow!");
        }
        protected override void PrintAnimal()
        {
            Console.WriteLine("Cat");
        }
    }

}

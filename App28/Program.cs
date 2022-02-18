using System;

namespace App28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newAnimal1 = new Dog("Buddy");
            var newAnimal2 = new Cat("Kitty");
            var newAnimal3 = new Animal("Other");

            newAnimal1.Say();
            newAnimal1.GiveVoice();
            newAnimal2.Say();
            newAnimal2.GiveVoice();
            newAnimal3.Say(); 
            newAnimal3.GiveVoice();

            newAnimal1.Print();
            newAnimal2.Print();
            newAnimal3.Print();
        }
    }
    class Animal
    {
        protected string _name; //properties
        public void Print()
        {
            PrintAnimal();
        }

        public Animal(string name) // konstruktor
        {
            _name = name;
        }
        public string Name()
        { return _name; }

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

    }
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

using System;
using System.Collections.Generic;

namespace App30
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var newAnimal1 = new Dog("Buddy");
            var newAnimal2 = new Cat("Kitty");
            var newAnimal3 = new Animal("Other");
            var Animal4 = new Animal("Lazy");

            newAnimal1.Say();
            newAnimal1.GiveVoice();
            newAnimal2.Say();
            newAnimal2.GiveVoice();
            newAnimal3.Say();
            newAnimal3.GiveVoice();

            newAnimal1.Print();
            newAnimal2.Print();
            newAnimal3.Print();
            Animal.CountAnimal();

            Bird newBird = new Bird();
            newBird.Fly();
            Plane newPlane = new Plane();
            newPlane.Fly();

            var realDateProvider = new RealDateProvider();
            Console.WriteLine(realDateProvider.Now());

            var fakeDateProvider = new FakeDateProvider();
            Console.WriteLine(fakeDateProvider.Now());

            var sths = new List<Sth>();

            sths.Add(new Sth("Alexsandra"));
            sths.Add(new Sth("Bobby"));
            sths.Add(new Sth("Charles"));

            foreach(var sth in sths)
            {
                Console.WriteLine(sth);
            }
        }
    }
}

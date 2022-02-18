using System;

namespace App29
{

    interface IFlyable
    {
        void Fly();

    }

    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying bird");
        }
    }
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying plane");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Plane plane = new Plane();
            bird.Fly();
            plane.Fly();

        }
    }


}


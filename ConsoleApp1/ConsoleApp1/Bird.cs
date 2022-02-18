using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying bird");
        }
    }
}

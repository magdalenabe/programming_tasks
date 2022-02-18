using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Sth: System.Object
    {
        public string name;

        public Sth( string name )
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }

}

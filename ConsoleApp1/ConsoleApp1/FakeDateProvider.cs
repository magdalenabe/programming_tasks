using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    internal class FakeDateProvider : IDateProvider
    {
       

        public DateTime Now()
        {
            var date = DateTime.Parse("2022,02,16");
            return date;
        }

    }
}

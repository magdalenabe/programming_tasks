using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
     class RealDateProvider : IDateProvider
    {
        public DateTime Now()
        {
            var date = DateTime.Now;
            return date;
        }

        
    }
}

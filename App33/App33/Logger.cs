using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App33
{
    internal class Logger
    {
        public static void Log (string program, DateTime dateTime, string msg)
        {
            Console.WriteLine("Game play: {0}, DateTime: {1}, Message: {2}", program, dateTime, msg);
        }
    }
}

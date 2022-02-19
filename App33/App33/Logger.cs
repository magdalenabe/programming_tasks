using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App33
{
    internal class Logger
    {
        const string programName = "Magic Ice";
        public static void Log (DateTime dateTime, string msg,  string program = programName)
        {
            Console.WriteLine($"Game play: {program}, DateTime: {dateTime}, Message: {msg}");
        }
    }
}

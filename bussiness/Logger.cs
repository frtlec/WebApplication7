using System;
using System.Collections.Generic;
using System.Text;

namespace bussiness
{
    public class Logger
    {
        public void LogInfo(string message)
        {
            System.Console.WriteLine($"[+] {message}");
        }
    }
}

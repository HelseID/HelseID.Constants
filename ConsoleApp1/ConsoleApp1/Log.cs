using System;
using System.Collections.Generic;
using System.Text;

namespace CertTests
{
    static class Log
    {
        public static void Info(string str)
        {
            Console.WriteLine(str);
        }

        public static void Error(string str)
        {
            Console.WriteLine($"ERR: {str}");
        }

    }
}

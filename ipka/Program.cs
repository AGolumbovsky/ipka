using System;
using System.Net;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static void Main()
        {
            try
            {
                Process.Start("netsh interface ip set address 'Ethernet 6' 10.10.10.55 255.255.255.0 10.10.10.1");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some kind of na error or some shit: " + ex.Message);
            }

            Console.ReadLine(); 
        }
    }
}
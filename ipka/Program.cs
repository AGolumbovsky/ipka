using System;
using System.Net;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string addr = "10.10.10.56";

                Console.WriteLine("the first argument is: " + args[0]);

                Console.WriteLine("netsh interface ip set address 'Ethernet 6'  {0} 255.255.255.0 10.10.10.1", addr);

                Process.Start("netsh interface ip set address 'Ethernet 6' {addr} 255.255.255.0 10.10.10.1");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some kind of na error or some shit: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
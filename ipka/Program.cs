using System;
using System.Net;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string adapter      = args[0];
            string statOrDyn    = args[1];
            string addr         = args[2];
            string gateway      = args[3];

            try
            {
                Console.WriteLine("netsh interface ip set address {0} {1} {2} {3}", adapter, statOrDyn, addr, gateway);
                Process.Start($"netsh interface ip set address {adapter} {statOrDyn} {addr} {gateway}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some kind of na error or some shit: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
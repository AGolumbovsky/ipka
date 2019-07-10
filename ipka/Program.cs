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

           /* String strHostName = string.Empty;
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            Console.WriteLine("This is only a test, no need to panic! But if you must panic, please do, not like we all don't have a good reason");

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }*/
            Console.ReadLine(); 
        }
    }
}
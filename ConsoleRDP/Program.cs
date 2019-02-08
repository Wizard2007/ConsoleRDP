using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxMSTSCLib;
using MSTSCLib;

namespace ConsoleRDP
{
    class Program
    {
        static void Main(string[] args)
        {
            MsRdpClient7 rdp = new MsRdpClient7() { Server = "192.168.2.109", UserName = "user" };
            rdp.AdvancedSettings8.ClearTextPassword = "user";
            rdp.Connect();
            Console.WriteLine(rdp.Connected);
            Console.ReadLine();
        }
    }
}

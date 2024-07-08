using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_sharp_App_ArielM.TransportationApp
{
    public class TransportationAppMain
    {
        public static void MainEntry()
        {
            Console.WriteLine("TransportationApp");
            MonitorTransportation monitor = new MonitorTransportation();
            monitor.Test1();
        }
    }
}

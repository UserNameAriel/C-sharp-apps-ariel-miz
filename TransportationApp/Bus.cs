using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp
{
    public class Bus : PublicVihcle
    {
        private readonly int doors;
        private bool bellStop = false;

        public int Doors => doors;

        public bool BellStop { get => bellStop; set => bellStop = value; }
    }
}

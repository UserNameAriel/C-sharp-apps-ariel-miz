using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp
{
    public class PassengerTrain
    {
        private Crone[] crones = null;
        private int cronesAmount = 0;

        public Crone[] Crones { get => crones; set => crones = value; }
        public int CronesAmount { get => cronesAmount; set => cronesAmount = value; }
    }
}

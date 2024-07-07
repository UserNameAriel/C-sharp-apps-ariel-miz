using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp
{
    public class PublicVihcle
    {
        private int line = 0;
        private int id = 0;
        private int maxSpeed = 0;
        private int currentPassengers = 0;
        private int seats = 0;
        private bool hasRoom = true;

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public virtual int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value <= 80)
                {
                    maxSpeed = value;
                }
               
            }
        }
    }

}

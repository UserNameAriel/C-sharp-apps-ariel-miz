using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp
{
    public class Crone
    {
        private readonly int rows, columns;

        public int Rows => rows;
        public int Columns => columns;
        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public Crone(Crone crone)
        {
            this.rows = crone.rows;
            this.columns = crone.columns;
        }

        public int GetSeats()
        {
            return rows * columns;
        }

        public int GetExtras()
        {
            return rows * 2;
        }
    }
}


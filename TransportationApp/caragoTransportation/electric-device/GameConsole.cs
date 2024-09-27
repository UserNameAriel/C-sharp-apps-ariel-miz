using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class GameConsole:ElectricProduct
    {
        private int gb;

        public GameConsole()
        {

        }

        public GameConsole(int gb):base("name",0,0,0,0)
        {
            this.gb = gb;
        }
        public  void  SetMaxWatt(int watt)
        {
            if(watt>250)
            this.watt=watt;
        }

        public void DisplayGameConsole()
        {
            DisplayD();
            Console.WriteLine("gb is " + gb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class PlayStation:GameConsole
    {
        private int gb_playstation;
        private string color;

        public override bool Equals(object obj)
        {

            if(obj is PlayStation)
            {
                return ((PlayStation)obj).color == this.color;
            }

            return false;
        }

        public PlayStation() { }
        public PlayStation(int gb_playstation, string color):base(0)
        {
            this.gb_playstation = gb_playstation;
            this.color = color;
        }

        public void DisplayPlayStation()
        {
            base.DisplayGameConsole();
            Console.WriteLine($"gb in PlayStatin is {gb_playstation} and the color is {color}");
        }
    }
}

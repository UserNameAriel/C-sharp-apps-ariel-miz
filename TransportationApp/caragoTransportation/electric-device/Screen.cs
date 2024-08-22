using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class Screen:ElectricProduct
    {
        private int size;

        public Screen(int size):base("name",0,0,0,0)
        {
            this.size = size;
        }

        public void DisplayScreen()
        {
            base.DisplayD();
            Console.WriteLine("the size is "+size);
        }
    }
}

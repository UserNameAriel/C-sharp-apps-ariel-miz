using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class DemoInharitance
    {
        public static void demo()
        {
            PC pc = new PC("Asus ROG");
            Part part = new Part("Asus ROG", "RAM", 250);
            SystemOnPC sys = new SystemOnPC("Asus ROG", "Windows", "Avast", part);
            Console.WriteLine(sys.ToString());
            Console.WriteLine("Test inharitance");
            ElectricProduct ep = new ElectricProduct("TV", 0, 26, 34, 3);
            Console.WriteLine("Electric Product");
            ep.SetWatt(151);
            ep.DisplayD();
            Console.WriteLine("Screen");
            Screen s = new Screen(45);
            s.DisplayScreen();
            Console.WriteLine("TV");
            Tv tv = new Tv(true);
            tv.DisplayTv();
            Console.WriteLine("Game Console");
            GameConsole gc = new GameConsole(23);
            gc.SetWatt(230);
            gc.DisplayGameConsole();
            Console.WriteLine("PlayStation");
            PlayStation ps = new PlayStation(1000, "black");
            ps.DisplayPlayStation();

            Console.WriteLine("\nDemo Casting\n");
            ElectricProduct electricProduct = new ElectricProduct();

            //DemoParameterCasting(electricProduct);//not working
            //DemoParameterCasting((Tv)electricProduct);//run time error

            DemoParameterCasting(new PlayStation());

            PlayStation p1 = new PlayStation(4, "black");
            PlayStation p2 = new PlayStation(14, "black");
            PlayStation p3 = new PlayStation(4, "white");

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

            int x = 5;
            int y = 5;

            ElectricProduct electricProduct2 = new ElectricProduct();
            ElectricProduct electricProduct3 = electricProduct;




            Console.WriteLine(x.Equals(y));
            Console.WriteLine(electricProduct.Equals(electricProduct2));
            Console.WriteLine(electricProduct.Equals(electricProduct3));
            List<String> list1 = new List<string>();
            list1.Add("One");
            list1.Add("Two");

            list1.Add("Three");

            Console.WriteLine(string.Join("*", list1));

            Console.WriteLine(list1[1]);
            Console.WriteLine("size = " + list1.Count);



        }



        public static void DemoParameterCasting(Screen screen)
        {
            Console.WriteLine(screen);
        }

        public static void DemoParameterCasting(Tv tv)
        {
            Console.WriteLine(tv);
        }
        public static void DemoParameterCasting(GameConsole gameConsole)
        {
            Console.WriteLine(gameConsole);
        }

        public static void DemoParameterCasting(ElectricProduct electricProduct)
        {
            Console.WriteLine(electricProduct);
        }

    }
}

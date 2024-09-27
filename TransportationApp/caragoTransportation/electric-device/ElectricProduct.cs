using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_sharp_App_ArielM.TransportationApp.caragoTransportation;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;
namespace c_sharp_basics_lingar.inheritance
{
    public class ElectricProduct : IPortable
    {
        private string name;
        protected double watt;
        private int height;
        private int width;
        public double weight;
        public static int serialNum;
        private bool packaged;
        private bool loaded;
        private StorageStructure location;
        public double Volume { get; set; }
        public bool isFragile { get; set; }

        public ElectricProduct() { }
        public ElectricProduct(string name, double watt, int height, int width, double weight)
        {
            this.name = name;
            this.watt = watt;
            this.height = height;
            this.width = width;
            this.weight = weight;
        }
        public void SetWatt(int watt)
        {
            if(watt>150)
            {
                return;
            }
            this.watt=watt;
        }
        public void DisplayD()
        {
            Console.WriteLine($"name is {name}, watt is {watt}, height is {height}, width is {width},weight is {weight}  ");
        }

        public double GetArea()
        {
            return weight * height;
        }

        public StorageStructure GetLocation()
        {
            return location;
        }

        public int[] GetSize()
        {
            return new int[] { height, width, (int)weight };
        }

        public double GetVolume()
        {
            return this.Volume;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public bool IsFragile()
        {
            return isFragile;
        }

        public bool IsLoaded()
        {
            return loaded;
        }

        public bool IsPackaged()
        {
            return packaged;
        }

        public void PackageItem()
        {
            packaged = true;
        }

        public void UnPackage()
        {
            packaged = false;
        }

    }
}

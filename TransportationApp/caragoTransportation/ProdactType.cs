using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class ElectricalItem : IPortable
    {
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public StorageStructure GetLocation()
        {
            throw new NotImplementedException();
        }

        public int[] GetSize()
        {
            throw new NotImplementedException();
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public double GetWeight()
        {
            throw new NotImplementedException();
        }

        public bool IsFragile()
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public bool IsPackaged()
        {
            throw new NotImplementedException();
        }

        public void PackageItem()
        {
            throw new NotImplementedException();
        }

        public void UnPackage()
        {
            throw new NotImplementedException();
        }
    }

    public class GeneralItem : IPortable
    {
        // Implement IPortable methods
        // Add additional properties and methods specific to GeneralItem

        public override string ToString()
        {
            return "General Item";
        }
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public StorageStructure GetLocation()
        {
            throw new NotImplementedException();
        }

        public int[] GetSize()
        {
            throw new NotImplementedException();
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public double GetWeight()
        {
            throw new NotImplementedException();
        }

        public bool IsFragile()
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public bool IsPackaged()
        {
            throw new NotImplementedException();
        }

        public void PackageItem()
        {
            throw new NotImplementedException();
        }

        public void UnPackage()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Furniture : IPortable
    {
        private bool packaged;
        private bool loaded;
        private StorageStructure location;
        public bool isFragile { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Height {  get; set; }
        public double Width {  get; set; }
        public double Depth {  get; set; }
        public abstract string FurnitureType { get; }

        public double GetArea()
        {
           return this.Weight * this.Volume;
        }

        public StorageStructure GetLocation()
        {
            return location;
        }

        public int[] GetSize()
        {
            return new int[] { (int)this.Width, (int)this.Height, (int)this.Depth };
        }

        public double GetVolume()
        {
            return this.Volume;
        }

        public double GetWeight()
        {
            return this.Weight;
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

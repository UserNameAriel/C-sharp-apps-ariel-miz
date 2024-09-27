using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class interfacesAndMathods
    {
        //interface class
        public interface IPortable
        {
            double GetArea();
            int[] GetSize();
            double GetVolume();
            double GetWeight();
            void PackageItem();
            bool IsPackaged();
            void UnPackage();
            bool IsFragile();
            StorageStructure GetLocation();
            bool IsLoaded();
        }
        public interface IContainable
        {
            abstract bool Load(IPortable item);
            abstract bool Load(List<IPortable> items);
            abstract bool Unload(IPortable item);
            abstract bool Unload(List<IPortable> items);
            abstract bool Unload();  
            bool IsHaveRoom();
            bool IsOverload();
            double GetMaxVolume();
            double GetMaxWeight();
            double GetCurrentVolume();
            double GetCurrentWeight();
        }
        //abstract class
        public abstract class StorageStructure : IContainable
        {
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public int Number { get; set; }
            public CargoType PortType { get; set; }
            public double MaxVolume { get; set; }
            public double MaxWeight { get; set; }

            private double curentVolume;
            private double curentWeight;

            public List<IPortable> StoredItems { get; set; }

            public StorageStructure(string country, string city, string street, int number, double maxVolume, double maxWeight)
            {
                Country = country;
                City = city;
                Street = street;
                Number = number;
                MaxVolume = maxVolume;
                MaxWeight = maxWeight;
                StoredItems = new List<IPortable>();
                curentVolume = 0;
                curentWeight = 0;
            }

            public bool Load(IPortable item)
            {
                if (IsHaveRoom() && !IsOverload(item.GetWeight(), item.GetVolume()))
                {
                    StoredItems.Add(item);
                    curentVolume += item.GetVolume();
                    curentWeight += item.GetWeight();
                    return true;
                }
                return false;
            }

            public bool Load(List<IPortable> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (!Load(items[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            public bool Unload(IPortable item)
            {
                if (StoredItems.Contains(item))
                {
                    StoredItems.Remove(item);
                    curentVolume = curentVolume - item.GetVolume();
                    curentWeight = curentWeight - item.GetWeight();
                    return true;
                }
                return false;
            }

            public bool Unload(List<IPortable> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (!Unload(items[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            public bool Unload()
            {
                StoredItems.Clear();
                curentVolume = 0;
                curentWeight = 0;
                return true;
            }

            public bool IsHaveRoom()
            {
                return curentVolume < MaxVolume && curentWeight < MaxWeight;
            }

            public bool IsOverload()
            {
                return curentWeight > MaxWeight || curentVolume > MaxVolume;
            }

            private bool IsOverload(double weight, double volume)
            {
                return curentWeight + weight > MaxWeight || curentVolume + volume > MaxVolume;
            }

            public double GetMaxVolume()
            {
                return MaxVolume;
            }

            public double GetMaxWeight()
            {
                return MaxWeight;
            }

            public double GetCurrentVolume()
            {
                return curentVolume;
            }

            public double GetCurrentWeight()
            {
                return curentWeight;
            }
        }


    }
}
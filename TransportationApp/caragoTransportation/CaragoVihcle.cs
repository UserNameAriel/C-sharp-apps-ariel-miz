using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class CaragoVihcle
    {
        public abstract class CargoVehicle : IContainable
        {
            public string Driver { get; set; }
            public double MaxWeight { get; set; }
            public double MaxVolume { get; set; }
            public bool IsReadyToDrive { get; set; }
            public bool IsOverloaded { get; set; }
            public StorageStructure NextPort { get; set; }
            public StorageStructure CurrentPort { get; set; }
            public int TravelID { get; set; }
            public List<IPortable> CargoItems { get; set; }
            public Dictionary<string, double> ExpectedPayment { get; set; }
            public int DistanceToNextPort { get; set; }
            public IShippingPriceCalculator PriceCalculator { get; set; }

            public CargoVehicle(double maxWeight, double maxVolume)
            {
                MaxWeight = maxWeight;
                MaxVolume = maxVolume;
                CargoItems = new List<IPortable>();
                ExpectedPayment = new Dictionary<string, double>();
                this.TravelID = new Random().Next(1000, 10000);
            }

            public bool Load(IPortable item)
            {
                if (IsOverload(item.GetWeight(), item.GetVolume()))
                {
                    return false;
                }

                CargoItems.Add(item);
                return true;
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
                if (CargoItems.Remove(item))
                {
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
            //מסיר את כל הרשימה 
            public bool Unload()
            {
                CargoItems.Clear();
                return true;
            }

            public bool IsHaveRoom()
            {
                return GetCurrentVolume() < MaxVolume && GetCurrentWeight() < MaxWeight;
            }

            public bool IsOverload()
            {
                return GetCurrentWeight() > MaxWeight || GetCurrentVolume() > MaxVolume;
            }
            //whene add an item
            private bool IsOverload(double weight, double volume)
            {
                return (GetCurrentWeight() + weight > MaxWeight) || (GetCurrentVolume() + volume > MaxVolume);
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
                double currentVolume = 0;
                for (int i = 0; i < CargoItems.Count; i++)
                {
                    currentVolume += CargoItems[i].GetVolume();
                }
                return currentVolume;
            }

            public double GetCurrentWeight()
            {
                double currentWeight = 0;
                for (int i = 0; i < CargoItems.Count; i++)
                {
                    currentWeight += CargoItems[i].GetWeight();
                }
                return currentWeight;
            }

            public void LoadCargo(List<IPortable> itemsToLoad)
            {
                for (int i = 0; i < itemsToLoad.Count; i++)
                {
                    Load(itemsToLoad[i]);

                }
            }

            public void ApproveForTravel()
            {
                IsReadyToDrive = true;
            }

            public void CalculateFinalPrice()
            {

                for (int i = 0; i < CargoItems.Count; i++)
                {
                    double itemPrice = PriceCalculator.CalculatePrice(CargoItems[i]);
                    ExpectedPayment[CargoItems[i].GetName()] = itemPrice;
                }
            }

            public void TravelToNextPort()
            {
                // Logic to travel to the next port, to be implemented as needed
            }

            public abstract string GetPricingList();
        }
    }
}

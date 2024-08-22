using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public interface IShippingPriceCalculator
    {
        double CalculatePrice(IPortable item, int travelDistance, CargoType cargoType);
        double CalculatePrice(List<IPortable> items, int travelDistance, CargoType cargoType);
    }

    public class ShippingPriceCalculator : IShippingPriceCalculator
    {
        public double CalculatePrice(IPortable item, int travelDistance, CargoType cargoType)
        {
            int unitCount = GetUnitCount(item);
            return CalculateCost(unitCount, travelDistance, item.IsFragile(), cargoType);
        }

        public double CalculatePrice(List<IPortable> items, int travelDistance, CargoType cargoType)
        {
            int totalUnitCount = 0;
            bool hasFragileItems = false;

            for (int i = 0; i < items.Count; i++)
            {
                totalUnitCount += GetUnitCount(items[i]);
                if (items[i].IsFragile())
                {
                    hasFragileItems = true;
                }
            }


            return CalculateCost(totalUnitCount, travelDistance, hasFragileItems, cargoType);
        }

        private int GetUnitCount(IPortable item)
        {
            int volumeUnits = (int)(item.GetVolume() / 100);
            int weightUnits = (int)(item.GetWeight());
            int totalUnits = volumeUnits + weightUnits;

            if (item.IsFragile())
            {
                totalUnits *= 2;
            }

            return totalUnits;
        }

        private double GetCostPerUnit(CargoType cargoType)
        {
            return cargoType switch
            {
                CargoType.Airplane => 2.0,
                CargoType.Ship => 0.5,
                CargoType.Train => 0.8,
                _ => 1.0, 
            };
        }

        private double CalculateCost(int unitCount, int travelDistance, bool isFragile, CargoType cargoType)
        {
            double costPerUnit = GetCostPerUnit(cargoType);
            double fragileMultiplier = isFragile ? 1.5 : 1.0;

            return unitCount * costPerUnit * travelDistance * fragileMultiplier;
        }
    }

}

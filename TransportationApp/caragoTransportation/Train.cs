using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.CaragoVihcle;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.regularClsses;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class Train : CargoVehicle
    {
        public List<IContainable> Wagons { get; set; }

        public Train(Driver driver, double maxWeight, double maxVolume, int DistanceToNextPort, List<IContainable> wagons) : base(driver, maxWeight, maxVolume)
        {
            this.Wagons = wagons;
        }
        public override bool Load(IPortable item)
        {
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].IsHaveRoom())
                {
                    return Wagons[i].Load(item);
                }
            }
            return false;
        }

        public override bool Load(List<IPortable> items)
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

        public override bool Unload(IPortable item)
        {
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].Unload(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Unload(List<IPortable> items)
        {
            bool result = true;
            for (int i = 0; i < items.Count; i++)
            {
                result &= Unload(items[i]);
            }
            return result;
        }

        public override string GetPricingList()
        {
            throw new NotImplementedException();
        }
        private bool IsOverload(double weight, double volume)
        {
            return (GetCurrentWeight() + weight > MaxWeight) || (GetCurrentVolume() + volume > MaxVolume);
        }

    }
}

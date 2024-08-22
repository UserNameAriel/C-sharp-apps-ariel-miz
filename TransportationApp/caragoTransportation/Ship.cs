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
    public class Ship : CargoVehicle
    {

        public List<IContainable> Containers { get; set; }


        public Ship(Driver driver, double maxWeight, double maxVolume, int DistanceToNextPort) : base(driver, maxWeight, maxVolume)
        {
            Containers = new List<IContainable>();
        }
        public override bool Load(IPortable item)
        {
            for (int i = 0; i < Containers.Count; i++)
            {
                if (Containers[i].Load(item))
                {
                    return true;
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
            for (int i = 0; i < Containers.Count; i++)
            {
                if (Containers[i].Unload(item))
                {
                    return true;
                }
            }
            return false;
        }


        public override bool Unload(List<IPortable> items)
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

        public override bool Unload()
        {
            bool result = true;
            for (int i = 0; i < Containers.Count; i++)
            {
                result &= Containers[i].Unload();
            }
            return result;
        }

        public override string GetPricingList()
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class Plane : CargoVehicle
    {
        public IContainable StorageRoom { get; set; }

        public Plane(Driver driver, double maxWeight, double maxVolume, int travelID, IShippingPriceCalculator priceCalculator, IContainable storageRoom) : base(driver, maxWeight, maxVolume)
        {

            StorageRoom = storageRoom;
        }

        public override bool Load(IPortable item)
        {
           
            if (StorageRoom.IsHaveRoom() && !StorageRoom.IsOverload())
            {
                StorageRoom.Load(item);
                return true;
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
            if (StorageRoom.Unload(item))
            {
                StorageRoom.Unload(item);
                return true;
            }
            return false;
        }

        public override bool Unload(List<IPortable> items)
        {
            bool result = true;
            foreach (var item in items)
            {
                result &= Unload(item);
            }
            return result;
        }


        public override string GetPricingList()
        {
            throw new NotImplementedException();
        }
    }

}

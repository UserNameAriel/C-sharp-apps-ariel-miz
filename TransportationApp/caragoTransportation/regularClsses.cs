using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.CaragoVihcle;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class regularClsses
    {
        public class Driver
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string IDNumber { get; set; }
            public CargoType DriverType { get; set; }

            public Driver(string firstName, string lastName, string idNumber, CargoType driverType)
            {
                FirstName = firstName;
                LastName = lastName;
                IDNumber = idNumber;
                DriverType = driverType;
            }

            public void Approve(CargoVehicle vehicle, StorageStructure nextPort)
            {
                
                if (!vehicle.IsOverload() && vehicle.IsHaveRoom())
                {
                    vehicle.NextPort = nextPort;

                    vehicle.IsReadyToDrive = true;
                }
                else
                {
                    vehicle.IsReadyToDrive = false;
                }
            }
        }

    }
}

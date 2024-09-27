using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static C_sharp_App_ArielM.TransportationApp.caragoTransportation.interfacesAndMathods;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class Port : StorageStructure
    {
        public CargoType PortType { get; set; }

        public StorageStructure[] Warehouses { get; set; }


        public Port(CargoType portType, StorageStructure[] warehouses, string country, string city, string address, int capacity, double area, double volume) : base(country, city, address, capacity, area, volume)
        {
            this.PortType = portType;
            this.Warehouses = warehouses;
        }

       
    }
    public class Warehouse : StorageStructure
    {
        public Warehouse(string country, string city, string street, int number, double maxVolume, double maxWeight) : base(country, city, street, number, maxVolume, maxWeight)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;
        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.TransportationApp.caragoTransportation
{
    public class Chair : Furniture
    {
        public override string FurnitureType => "Chair";

        // Additional properties and methods specific to Chair
    }

    public class Table : Furniture
    {
        public override string FurnitureType => "Table";

        // Additional properties and methods specific to Table
    }

    public class Sofa : Furniture
    {
        public override string FurnitureType => "Sofa";

        // Additional properties and methods specific to Sofa
    }

}

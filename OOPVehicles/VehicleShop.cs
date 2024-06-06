using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class VehicleShop 
    {     
        public List<VehicleShop> vehicleShop = new List<VehicleShop>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicleShop.Add(vehicle);
        }
        public void ShowVehicleList() 
        {
            string List = "";

        }
    }
}


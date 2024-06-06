using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Motorcycle : Vehicle
    {
        public string EngineCapacity { get; set; }
        public Motorcycle(string EngineCapacity, string model, int year, string registrationNumber, double v)
        {
            this.model = model;
            this.year = year;
            this.registrationNumber = registrationNumber;
            this.EngineCapacity = EngineCapacity;
        }

        
       
        
    }
}

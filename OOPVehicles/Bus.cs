using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Bus : Vehicle
    {
        public int Capacity { get; set; }
        public Bus(int Capacity, string model, int year, string registrationNumber, double v)
        {
            this.Capacity = Capacity;
            this.model = model;
            this.year = year;
            this.registrationNumber = registrationNumber;
        }

        
        
        
    }
}

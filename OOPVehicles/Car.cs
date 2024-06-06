using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Car : Vehicle
    {
         public int NumberOfDoors { get; set; }
        public Car(int NumberOfDoors, string model, int year, string registrationNumber, int v)
        {
            this.NumberOfDoors = NumberOfDoors;
            this.model = model;
            this.year = year;
            this.registrationNumber = registrationNumber;
        }

       
        
    }
}

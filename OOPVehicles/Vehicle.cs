using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Vehicle
    {
        public string model {get;set;}
        public int year { get;set;}
        public string registrationNumber { get; set;}
        public void Vehil( string model, int year, string registrationNumber)
        {
            this.model = model;
            this.year = year;
            this.registrationNumber = registrationNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Inheritance
{
    internal class Vehicle
    {   
        public string type;
        public string model;
        public int yearOfManufacture;
        public char awardWinning;
        
        public Vehicle(string type, string model, int yearOfManufacture, char awardWinning)
        {
            this.type = type;   
            this.model = model;
            this.yearOfManufacture = yearOfManufacture;
            this.awardWinning = awardWinning;
        }
        public void VehicleDetails()
        {
            Console.WriteLine("Type of vehicle : {0}, Model : {1}, Year of Manufacture : {2}, Is Award Winning : {3}", type, model, yearOfManufacture, awardWinning);
        }
    }
}

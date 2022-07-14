using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Inheritance
{
    internal class Car : Vehicle
    {
        public Car(string type, string model, int yearOfManufacture, char awardWinning) : base(type, model, yearOfManufacture, awardWinning)
        {
            this.type = type;
            this.model = model;
            this.yearOfManufacture = yearOfManufacture;
            this.awardWinning = awardWinning;
        }
    }
}

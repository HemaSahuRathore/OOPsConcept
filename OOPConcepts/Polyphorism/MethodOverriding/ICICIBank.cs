using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polyphorism.MethodOverriding
{
    internal class ICICIBank : Bank
    {
        public new void InterestPercentage()
        {
            Console.WriteLine("12% Interest rate applying from ICICI Bank");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polyphorism.MethodOverriding
{
    public class Bank
    {
        public string bankName;
        public string branch;

        public void BankDetails()
        {
            Console.WriteLine("BankName:{0} Branch:{1}", bankName, branch);
        }

        public void CustomerDetails(string customerName, int customerID)
        {
            Console.WriteLine("Customer Name : {0}, Customer ID : {1}", customerName, customerID);
        }

        public void InterestPercentage()
        {
            Console.WriteLine("Every bank has its own interest rate");
        }
    }

    public class HDFCBank : Bank
     {
        public new void InterestPercentage()
        {
            Console.WriteLine("12% Interest Rate is applying");
        }
     }

}

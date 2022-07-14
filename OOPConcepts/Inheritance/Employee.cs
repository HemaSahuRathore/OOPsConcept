using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Inheritance
{
    internal class Employee
    {
        public int employeeID;
        public long phoneNumber;
        public string empName;
        public string companyName;

        public void EmployeeDetails()
        {
            Console.WriteLine("Employee name: {0}, Employee ID: {1}, Phone number: {2}", empName, employeeID, phoneNumber);

        }

        public void CompanyDetails()
        {
            Console.WriteLine("{0} works in {1} Company", empName, companyName);
        }
    }
}

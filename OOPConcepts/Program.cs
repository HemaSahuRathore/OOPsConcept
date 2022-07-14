using OOPConcepts.Inheritance;
using OOPConcepts.Polyphorism.MethodOverloading;
using OOPConcepts.Polyphorism.MethodOverriding;
using OOPConcepts.Encapsulation;
using OOPConcepts.Abstraction;

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from option shown below");
            Console.WriteLine("1.Inheritence \n2.Polymorphism-Overloading \n3.Polymorphism-Overriding \n4.Encapsulation \n5.Abstraction");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //Employee Inheritance Demo
                    FullTimeEmployee emp1 = new FullTimeEmployee();
                    emp1.employeeID = 123;
                    emp1.empName = "Hema";
                    emp1.companyName = "Mindtree";
                    emp1.phoneNumber = 9916523655;

                    emp1.EmployeeDetails();
                    emp1.CompanyDetails();
                    Console.WriteLine();

                    //Vehicle Inheritance Demo
                    Car Baleno = new Car("Baleno", "2022", 2022, 'Y');
                    Baleno.VehicleDetails();

                    Bike Pulsar = new Bike("Pulsar", "220", 2018, 'N');
                    Pulsar.VehicleDetails();
                    break;

                case 2:
                    Addition add = new Addition();
                    add.Add(3, 5);
                    Console.WriteLine((add.Add(3, 5, 9)));
                    Console.WriteLine(add.Add(3.8f, 5, 9));
                    Console.WriteLine(add.Add(3, 5.8f, 9));
                    break;
                
                case 3:
                    HDFCBank B1 = new HDFCBank();
                    B1.bankName = "HDFC";
                    B1.branch = "Bangalore";
                    B1.CustomerDetails("Hema",25);
                    B1.BankDetails();
                    B1.InterestPercentage();
                    break;

                case 4:
                    Student student = new Student();
                    ////set value using property name
                    //student.Name = "Hema";
                    //student.Address = "Bangalore";

                    ////access value using property name
                    //Console.WriteLine("Student Name is " + student.Name);
                    //Console.WriteLine("Student Address is " + student.Address);
                    Console.WriteLine("Student Name" + student.StudentDetails("Hema"));
                    break;

              default:
                    Cat cat = new Cat();
                    cat.Sound();
                    break;
            }


        }

    }

}
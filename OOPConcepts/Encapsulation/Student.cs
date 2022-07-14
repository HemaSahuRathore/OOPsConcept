using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Encapsulation
{
    internal class Student
    {
        private string studentName;
        private string address;

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value; //assign parameter passed while initializing
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string StudentDetails(string name)
        {
            if (name.Length > 2)
            {
                studentName = name;
            }
            else
            {
                Console.WriteLine("Please enter name consisting atleast 3 char");
            }
            return studentName;
        }
    }
}


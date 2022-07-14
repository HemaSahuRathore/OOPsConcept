using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Abstraction
{
    //Abstract class
    abstract class Animal
    {
        //Abstract method does not have body
        public abstract void Sound();
        public void sleep()
        {
            Console.WriteLine("Zzzz....");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Abstraction
{
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}

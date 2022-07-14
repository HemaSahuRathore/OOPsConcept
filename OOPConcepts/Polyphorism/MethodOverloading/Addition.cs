using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Polyphorism.MethodOverloading
{
    internal class Addition
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;

        }

        public float Add(float x, int y, int z)
        {
            return x + y + z;

        }
        public float Add(int x, float y, int z)
        {
            return x + y + z;

        }

    }
}

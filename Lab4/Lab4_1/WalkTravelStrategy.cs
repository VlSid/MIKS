using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class WalkTravelStrategy : ITravelStrategy
    {
        public void Move(string start, string destination)
        {
            Console.WriteLine($"Walking from {start} to {destination}. It will take some time, but it's free.");
        }
    }
}

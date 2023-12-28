using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class TrainTravelStrategy : ITravelStrategy
    {
        public void Move(string start, string destination)
        {
            Console.WriteLine($"Taking a train from {start} to {destination}. It costs 30 money.");
        }
    }
}

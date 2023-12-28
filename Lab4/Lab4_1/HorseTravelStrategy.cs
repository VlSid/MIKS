using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class HorseTravelStrategy : ITravelStrategy
    {
        public void Move(string start, string destination)
        {
            Console.WriteLine($"Riding a horse from {start} to {destination}. It costs 50 money.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class SteamboatTravelStrategy : ITravelStrategy
    {
        public void Move(string start, string destination)
        {
            Console.WriteLine($"Sailing on a steamboat from {start} to {destination}. It costs 40 money.");
        }
    }
}

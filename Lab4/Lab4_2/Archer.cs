using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Archer : IUnit
    {
        public string Name => "Archer";

        public bool ExecuteCommand(string command)
        {
            if (command == "AirAttack")
            {
                Console.WriteLine("Archer executing AirAttack command");
                return true;
            }
            return false;
        }
    }
}

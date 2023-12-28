using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Cavalry : IUnit
    {
        public string Name => "Cavalry";

        public bool ExecuteCommand(string command)
        {
            if (command == "FastMove")
            {
                Console.WriteLine("Cavalry executing FastMove command");
                return true;
            }
            return false;
        }
    }
}
